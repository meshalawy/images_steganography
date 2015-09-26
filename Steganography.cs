using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

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
            //First, check the available size and decide whether the image can fit data or not.
            bool[] colorsToUse = new bool[] { useRed, useBlue, useGreen, useAlpha };
            var colorsCount = colorsToUse.Count(b => b);
            var blockSize = aesEncryption ? 16 : 1;  //Aes block size = 16 byte
            var numberOfBits = hostImage.Width * hostImage.Height * bitsPerByte * colorsCount;
            var ImageMaxNumberOfBlocks = Math.Floor((Double)(numberOfBits / 8 / blockSize));
            var dataNumberOfBlocks = Math.Ceiling ((Double)(data.Length + HeaderLength)/blockSize);
            if (ImageMaxNumberOfBlocks < dataNumberOfBlocks)
                throw new ArgumentException("Data can not be fit in image with the selected options. This may cause a corrupted file when extracting. The maximum size is: " + getHumanReadableFileSizeString((ImageMaxNumberOfBlocks * blockSize) - 9));


            //Field 1
            //Data Size Field: Integers are 32 bits.
            BitArray bitsForDataSizeField = new BitArray(System.BitConverter.GetBytes(data.Length));

            //Field 2:
            //Data Type Field: Must ensure not to exceed 12 bytes. Also must ensure to fill the remaining bits in case of shorter extensions. 
            //Length of data type field = 96
            BitArray bitsForDataTypeField = new BitArray(Encoding.ASCII.GetBytes(dataType));
            if (bitsForDataTypeField.Count > 96)
                throw new ArgumentException("File extensions longer than 12 bytes (12 letters) are not supported.");
            else if (bitsForDataTypeField.Count < 96)
            {
                bool[] array = new bool[96];
                bitsForDataTypeField.CopyTo(array, 0);
                bitsForDataTypeField = new BitArray(array);
            }

            //Concatenating header, then encrypt it if required.
            BitArray bitsForHeader = bitsForDataSizeField.Append(bitsForDataTypeField);
            if (aesEncryption)
                bitsForHeader = new BitArray(AES_Encryption.AES_Encrypt(bitsForHeader.getBytes(), encryptionPassword));


            // Last part, the data itself
            // get the BitArray for the data
            BitArray bitsForData = new BitArray(data);
            if (aesEncryption)
                bitsForData = new BitArray(AES_Encryption.AES_Encrypt(bitsForData.getBytes(), encryptionPassword));


            //Concatenating all parts to one single BitArray in order to write it. 
            BitArray allBits = bitsForHeader.Append(bitsForData);

            //start writing allBits accross all pixels (line by line of pixels) on the selected colors and size 
            int index = 0;
            Bitmap modifiedImage = new Bitmap(hostImage);
            for (int y = 0; y < modifiedImage.Height && index < allBits.Count; y++)
            {
                for (int x = 0; x < modifiedImage.Width && index < allBits.Count; x++)
                {
                    Color pixel = modifiedImage.GetPixel(x, y);
                    Byte[] rgba = new Byte[] { pixel.R, pixel.G, pixel.B, pixel.A };
                    for (int bit = 0; bit < bitsPerByte; bit++)
                    {
                        for (int color = 0; color < rgba.Length; color++)
                        {
                            if (colorsToUse[color] && index < allBits.Count)
                            {
                                rgba[color] = changeBitInByte(rgba[color], bit, allBits.Get(index));
                                index++;
                            }
                        }
                    }
                    modifiedImage.SetPixel(x, y, Color.FromArgb(
                        System.Convert.ToInt32(rgba[3]),
                        System.Convert.ToInt32(rgba[0]),
                        System.Convert.ToInt32(rgba[1]),
                        System.Convert.ToInt32(rgba[2])));
                }
            }
            return modifiedImage;
        }

        public static Tuple<byte[], string> extractData(Bitmap hostImage,
                bool useRed, bool useGreen, bool useBlue, bool useAlpha,
                int bitsPerByte,
                bool aesEncryption,
                string encryptionPassword)
        {   
            bool[] colorsToUse = new bool[] { useRed, useBlue, useGreen, useAlpha };
            var colorsCount = colorsToUse.Count(b => b);
            var blockSize = aesEncryption ? 16 : 1;  //Aes block size = 16 byte
            var numberOfBits = hostImage.Width * hostImage.Height * bitsPerByte * colorsCount;
            var ImageMaxNumberOfBlocks = Math.Floor((Double)(numberOfBits / 8 / blockSize));
            var headerNumberOfBlocks = Math.Ceiling((Double)(HeaderLength/blockSize));

            //at least it should be bigger than header length
            if (ImageMaxNumberOfBlocks < headerNumberOfBlocks )
                throw new ArgumentException("Can not extract data using the selected options. Try to enlarge the bit options.");

            var bitsArray = new Boolean[(int)ImageMaxNumberOfBlocks * blockSize * 8];
            var pointer = 0;
            for (int y = 0; y < hostImage.Height; y++)
            {
                for (int x = 0; x < hostImage.Width; x++)
                {
                    Color pixel = hostImage.GetPixel(x, y);
                    Byte[] rgba = new Byte[] { pixel.R, pixel.G, pixel.B, pixel.A };
                    for (int bit = 0; bit < bitsPerByte; bit++)
                    {
                        for (int color = 0; color < rgba.Length; color++)
                        {
                            if (colorsToUse[color])
                            {
                                bitsArray[pointer++] = (getBit(rgba[color], bit));
                            }
                        }
                    }
                }
            }

            var allBits = new BitArray(bitsArray);

            var bitsForHeader = new BitArray(allBits.getRange(0,(int) headerNumberOfBlocks * blockSize * 8));
            if (aesEncryption)
                bitsForHeader = new BitArray(AES_Encryption.AES_Encrypt(bitsForHeader.getBytes(), encryptionPassword));

            var dataSize = getIntFromBooleanArray(bitsForHeader.getRange(0, 32).ToArray());
            var dataNumberOfBlocks = Math.Ceiling((Double) (dataSize/blockSize));

            //The ramaining blocks should fit the data size;
            if (dataSize<0 ||
                (ImageMaxNumberOfBlocks - headerNumberOfBlocks)< dataNumberOfBlocks )
                throw new ArgumentException("Can not extract data using the selected options. Try to change colors and bit options.");

            string dataType = Encoding.ASCII.GetString(getBytesFromBooleanArray(bitsForHeader.getRange(32, 96).ToArray())).TrimEnd('\0');

            //check illegal characters in data type (extension) because wrong options can generate unexpected data in data type field.
            if (dataType.IndexOfAny(System.IO.Path.GetInvalidFileNameChars()) >= 0)
                throw new ArgumentException("Found illegale and wrong data type!. Typically this occures due to the wrong options.");

            var bitsForData = new BitArray(allBits.getRange(HeaderLength * 8, (int) dataNumberOfBlocks * blockSize * 8));
            if(aesEncryption)
                bitsForData = new BitArray(AES_Encryption.AES_Encrypt(bitsForData.getBytes(), encryptionPassword));

            return new Tuple<byte[], string>(bitsForData.getBytes(), dataType);
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

        private static int getIntFromBooleanArray(Boolean[] boolArray)
        {
            if (boolArray.Length > 32)
                throw new ArgumentException("Argument length shall be at most 32 bits.");
            BitArray ba = new BitArray(boolArray);
            int[] array = new int[1];
            ba.CopyTo(array, 0);
            return array[0];
        }

        private static byte[] getBytesFromBooleanArray(Boolean[] boolArray)
        {
            if (boolArray.Length % 8 != 0)
                throw new ArgumentException("bits count should be multiple of 8");

            BitArray ba = new BitArray(boolArray);
            byte[] bytes = new byte[boolArray.Length / 8];
            ba.CopyTo(bytes, 0);
            return bytes;
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
