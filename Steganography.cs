using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace images_steganography
{
    class Steganography
    {
              /* The "steganografied" image will contains two parts of information:
               * 1- Header: descriptive information about the hidden data itself (16 bytes).
               *      A- Data size Field: represent data length in bytes.
               *          32 bits (4 Bytes) are allocated for this field (Maximum data size is 2GB).
               *          If encryption is used, then this field represent the encrypted data length.
               *      B- Data type Field: the extension of the file i.e. txt for text, JPG for images, docx for MS Word Documents etc.
               *          10 Bytes are allocated for this field and thus the extension should be 10 letters at maximum.
               *          Note that the period or the dot "." in the extension is not included.
               *      C- Extra Bytes: Reserved for padding when encrypting using AES
               *      
               * If encrypted is choosen, then the header will be encrypted too.
               *  
               * 2- Data: The actual data to be hided in the image (either encrypted or not).
               */

        private const int HeaderLength = 16;
        public static Bitmap hideData(Bitmap hostImage, Byte[] data, string dataType,
                bool useRed, bool useGreen, bool useBlue, bool useAlpha,
                int bitsPerByte,
                bool aesEncryption, 
                string encryptionPassword)
        {

            if (aesEncryption)
                data = AES_Encryption.AES_Encrypt(data, encryptionPassword);

            //Data Type Field: Must ensure not to exceed 10 bytes. Also must ensure to fill the remaining bits in case of shorter extensions. 
            Byte[] dataTypeBytes = Encoding.ASCII.GetBytes(dataType);
            if (dataTypeBytes.Length > 10)
                throw new ArgumentException("File extensions longer than 10 bytes (10 letters) are not supported.");
            else if (dataTypeBytes.Length <10)
            {
                //padding to fill the empty files.
                byte[] temp = new byte[10];
                dataTypeBytes.CopyTo(temp, 0);
                dataTypeBytes = temp;
            }

            //Data Size Field: Integers are 32 bits.
            //If data has been encrypted, then this is the length of the encrypted data
            byte[] dataSizeBytes = System.BitConverter.GetBytes(data.Length);

            //Concatenating the two fields into one array representing header, then encrypt it if required.
            byte[] headerBytes = dataSizeBytes.Concat(dataTypeBytes).ToArray();
            if (aesEncryption)
                headerBytes = AES_Encryption.AES_Encrypt(headerBytes, encryptionPassword);

            //padding the extra empty bytes in case of no encryption
            else if (headerBytes.Length < HeaderLength)
                headerBytes= headerBytes.Concat(new byte[HeaderLength - headerBytes.Length]).ToArray();
            

            //header must be exactly 16 bytes
            if (headerBytes.Length != HeaderLength)
                throw new ArgumentException(String.Format
                    ("Header should be 16 bytes length but found %s bytes. Contact the developer. Data size is: %s, Data Type is: %s",
                    headerBytes.Length, data.Length, dataType));

            //Order is important because Alph is the most significant byte in the colors ARGB
            List<LockBitmap.ColorComponent> colorsToUse = new List<LockBitmap.ColorComponent>();
            if (useBlue) colorsToUse.Add(LockBitmap.ColorComponent.Blue);
            if (useGreen) colorsToUse.Add(LockBitmap.ColorComponent.Green);
            if (useRed) colorsToUse.Add(LockBitmap.ColorComponent.Red);
            if (useAlpha) colorsToUse.Add(LockBitmap.ColorComponent.Alpha);

            var maxBytes = (hostImage.Width * hostImage.Height * bitsPerByte * colorsToUse.Count) / 8;

            if (maxBytes < headerBytes.Length + data.Length)
            {
                //finding the max possible size
                var blockSize = aesEncryption ? 16 : 1;
                var maxBlocks = Math.Floor((double)(maxBytes - headerBytes.Length) / blockSize);
                var maxSize = (maxBlocks * blockSize) - 1;
                throw new ArgumentException("Data can not be fit in image with the selected options. This may cause a corrupted file when extracting. The maximum size is: " + getHumanReadableFileSizeString(maxSize));
            }
                
            //Concatenating all parts to one single BitArray in order to write it. 
            BitArray allBits = new BitArray(headerBytes.Concat(data).ToArray());

            //start writing allBits accross all pixels (line by line of pixels) on the selected colors and size 
            LockBitmap imageData = new LockBitmap(new Bitmap(hostImage));
            imageData.LockBits();

            int maxThreads = 8;
            List<Thread> threads = new List<Thread>();

            int bitsPerThread = (int) Math.Ceiling((double)allBits.Count / maxThreads);
            for (int t = 0; t < maxThreads; t++)
            {
                int start = t * bitsPerThread;
                Thread thread = new Thread(( startIndex )=>{
                    int b, c, y, x, r;
                    int pixelCount = imageData.Width * imageData.Height;
                    int bytesToUse = pixelCount * colorsToUse.Count;
                    int end = (int)startIndex + bitsPerThread;
            
                    for (int i = (int) startIndex; i < end && i<allBits.Count; i++)
                    {
                        setCorrespondingXYCBInImageForDataBit(i, imageData, colorsToUse, out x, out y, out c, out b);
                        byte oldValue = imageData.GetColorComponent(x, y, colorsToUse[c]);
                        byte newValue = changeBitInByte(oldValue, b, allBits[i]);
                        imageData.SetColorComponent(x, y, colorsToUse[c], newValue);
                    }
                });
                thread.Start(start);
                threads.Add(thread);
            }
            foreach (Thread t in threads)
                t.Join();

            imageData.UnlockBits();
            return imageData.getImage() ;
        }

        private static void setCorrespondingXYCBInImageForDataBit(int bitIndex, LockBitmap image, List<LockBitmap.ColorComponent> colorsToUse, 
            out int x, out int y, out int c, out int b)
        {
            int r;
            int pixelCount = image.Width * image.Height;
            int bytesToUse = pixelCount * colorsToUse.Count;

            b = bitIndex / bytesToUse;
            r = bitIndex % bytesToUse;

            c = r / pixelCount;
            r = r % pixelCount;

            y = r / image.Width;
            x = r % image.Width;
        }

        public static Tuple<byte[], string> extractData(Bitmap hostImage,
                bool useRed, bool useGreen, bool useBlue, bool useAlpha,
                int bitsPerByte,
                bool aesEncryption,
                string encryptionPassword)
        {

            List<LockBitmap.ColorComponent> colorsToUse = new List<LockBitmap.ColorComponent>();
            if (useBlue) colorsToUse.Add(LockBitmap.ColorComponent.Blue);
            if (useGreen) colorsToUse.Add(LockBitmap.ColorComponent.Green);
            if (useRed) colorsToUse.Add(LockBitmap.ColorComponent.Red);
            if (useAlpha) colorsToUse.Add(LockBitmap.ColorComponent.Alpha);
            var numberOfBits = hostImage.Width * hostImage.Height * bitsPerByte * colorsToUse.Count;
           
            //at least it should be bigger than header length
            if (numberOfBits /8  < HeaderLength)
                throw new ArgumentException("Can not extract data using the selected options. Try to enlarge the bit options.");


            
            LockBitmap imageData = new LockBitmap(hostImage);
            imageData.LockBits();
            
            //Extract data: start by extracting header data:
            var headerLengthInBits = HeaderLength * 8;
            var headerBits = new Boolean[headerLengthInBits];
            int i, x, y, c, b;
            for (i = 0; i < headerLengthInBits; i++)
            { 
                setCorrespondingXYCBInImageForDataBit(i, imageData, colorsToUse, out x, out y, out c, out b);
                headerBits[i] = getBit(imageData.GetColorComponent(x, y, colorsToUse[c]), b);
            }

            byte[] headerBytes = new BitArray(headerBits).getBytes();
            if (aesEncryption)
                headerBytes = AES_Encryption.AES_Decrypt(headerBytes, encryptionPassword);

            var dataSize = BitConverter.ToInt32(headerBytes, 0);
            string dataType = Encoding.ASCII.GetString(headerBytes.Skip(4).Take(10).ToArray()).TrimEnd('\0');

            //check wrong data size and also check illegal characters in data type (extension) because wrong options can generate unexpected data in data type field.;
            if (dataSize < 0 ||
                dataType.IndexOfAny(System.IO.Path.GetInvalidFileNameChars()) >= 0 || 
                (numberOfBits-headerLengthInBits)/8 < dataSize)
                throw new ArgumentException("Can not extract data using the selected options. Try to change colors and bit options.");

            //read data bytes based on the dataSize found in header
            int dataSizeInBits = dataSize * 8;
            var dataBits = new Boolean[dataSizeInBits];
            int maxThreads = 8;
            List<Thread> threads = new List<Thread>();

            int bitsPerThread = (int) Math.Ceiling((double)dataSizeInBits / maxThreads);
            for (int t = 0; t < maxThreads; t++)
            {
                int start = t * bitsPerThread;
                Thread thread = new Thread(( startIndex )=>{
                    int end = (int)startIndex + bitsPerThread;
                    //double letters to differntiate from already defiend variables previously.
                    //without different name, all threads will be using the same variables with unsafe read/write for those variables.
                    int ii, xx, yy, cc, bb;
                    for (ii = (int) startIndex; ii < end && ii < dataSizeInBits; ii++)
                    {
                        setCorrespondingXYCBInImageForDataBit(ii + headerLengthInBits, imageData, colorsToUse, out xx, out yy, out cc, out bb);
                        dataBits[ii] = getBit(imageData.GetColorComponent(xx, yy, colorsToUse[cc]), bb);
                    }
                });
                thread.Start(start);
                threads.Add(thread);
            }
            foreach (Thread t in threads)
                t.Join();

            byte[] dataBytes = new BitArray(dataBits).getBytes();
            if (aesEncryption)
                dataBytes = AES_Encryption.AES_Decrypt(dataBytes, encryptionPassword);

            return new Tuple<byte[], string>(dataBytes, dataType);
        }

        private static byte changeBitInByte(byte originalByte, int bitIndex, bool newBitValue)
        {
            int x = System.Convert.ToInt16(newBitValue);
            return (byte)(originalByte ^ ((-x ^ originalByte) & (1 << bitIndex)));
        }

        private static bool getBit(byte b, int bitNumber)
        {
            return (b & (1 << bitNumber)) != 0;
        }

        private static string getHumanReadableFileSizeString(double bytesCount)
        {
            string[] sizes = { "B", "KB", "MB", "GB" };
            int order = 0;
            while (bytesCount >= 1024 && order + 1 < sizes.Length)
            {
                order++;
                bytesCount = bytesCount / 1024;
            }

            // Adjust the format string to your preferences. For example "{0:0.#}{1}" would
            // show a single decimal place, and no space.
            return String.Format("{0:0.##} {1}", bytesCount, sizes[order]);
        }
    }
}
