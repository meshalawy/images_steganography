using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
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
                //padding to fill the empty bits.
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


            //Order is important, becuause Color.ToArgb returns an integer whose sginificant bits represent Alpha, then red, then green then blue.
            //So the while loop can use the color index to find the color bytes.
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
            //Bitmap modifiedImage = new Bitmap(hostImage);
            Bitmap output = hostImage.Clone(new Rectangle(0,0,hostImage.Width, hostImage.Height), System.Drawing.Imaging.PixelFormat.Format32bppArgb);
           // LockBitmap lockBitmap = new LockBitmap(modifiedImage);
           // lockBitmap.LockBits();
            var width = output.Width;
            var height = output.Height;
            
            //i: index, b: bit, c: color, x & y are the two dimensions.
            int i = 0;
           
            for (int y = 0 ; y < height && i < allBits.Count; y++)
            {
                for (int x = 0 ; x < width && i < allBits.Count; x++)
                {
                    for (int b = 0; b < bitsPerByte && i < allBits.Count; b++)
                    {
                        for (int c = 0; c < colorsToUse.Count && i < allBits.Count; c++)
                        {
                            //byte old = lockBitmap.GetColorComponent(x, y, colorsToUse[c]);
                            //byte newValue = changeSingleBit(old, b, allBits[i++]);
                            //lockBitmap.SetColorComponent(x, y, colorsToUse[c], 0);
                            int old = output.GetPixel(x, y).ToArgb();
                            int newVlaue = changeSingleBit(old, (int)colorsToUse[c] * 8 + b, allBits[i++]);
                            output.SetPixel(x, y, Color.FromArgb(newVlaue));
                        }
                    }
                }
            }
          //  lockBitmap.UnlockBits();
            System.Diagnostics.Debug.Print(output.GetPixel(0, 0).ToArgb().ToString());
            return output;
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

            var bitsArray = new Boolean[numberOfBits];
            Bitmap modifiedImage = new Bitmap(hostImage);
            //LockBitmap lockBitmap = new LockBitmap(modifiedImage);
            //lockBitmap.LockBits();
            var width = modifiedImage.Width;
            var height = modifiedImage.Height;
            //i: index, b: bit, c: color, x & y are the two dimensions.
            int i = 0;
            System.Diagnostics.Debug.Print(modifiedImage.GetPixel(0, 0).ToArgb().ToString());
            
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    for (int b = 0; b < bitsPerByte; b++)
                    {
                        for (int c = 0; c < colorsToUse.Count; c++)
                        {
                           // bitsArray[i++] = (getBit(lockBitmap.GetColorComponent(x, y, colorsToUse[c]), b));
                            var color = modifiedImage.GetPixel(x, y).ToArgb();
                            bitsArray[i++] = (getBit(color, (int)colorsToUse[c] * 8 + b));
                        }
                    }
                }
            }

            byte[] allBytes = new BitArray(bitsArray).getBytes();

            byte[] HeaderBytes = allBytes.Take(HeaderLength).ToArray();
            if (aesEncryption)
                HeaderBytes = AES_Encryption.AES_Decrypt(HeaderBytes, encryptionPassword);

            var dataSize = BitConverter.ToInt32(HeaderBytes, 0);
            string dataType = Encoding.ASCII.GetString(HeaderBytes.Skip(4).Take(10).ToArray()).TrimEnd('\0');

            //The ramaining bytes should fit the data size;
            if (dataSize<0 ||
                (allBytes.Length - HeaderBytes.Length)< dataSize )
                throw new ArgumentException("Can not extract data using the selected options. Try to change colors and bit options.");

            //check illegal characters in data type (extension) because wrong options can generate unexpected data in data type field.
            if (dataType.IndexOfAny(System.IO.Path.GetInvalidFileNameChars()) >= 0)
                throw new ArgumentException("Found illegale and wrong data type!. Typically this occures due to the wrong options.");

            byte[] dataBytes = allBytes.Skip(16).Take(dataSize).ToArray();
            if(aesEncryption)
                dataBytes = AES_Encryption.AES_Decrypt(dataBytes, encryptionPassword);

            return new Tuple<byte[], string>(dataBytes, dataType);
        }

        private static int changeSingleBit(int original, int bitIndex, bool newBitValue)
        {
            int x = System.Convert.ToInt16(newBitValue);
            return (original ^ ((-x ^ original) & (1 << bitIndex)));
        }

        private static bool getBit(int b, int bitNumber)
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
