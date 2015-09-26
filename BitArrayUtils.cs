using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace images_steganography
{
    public static class BitArrayUtils
    {
        public static BitArray Prepend(this BitArray current, BitArray before)
        {
            var bools = new bool[current.Count + before.Count];
            before.CopyTo(bools, 0);
            current.CopyTo(bools, before.Count);
            return new BitArray(bools);
        }

        public static BitArray Append(this BitArray current, BitArray after)
        {
            var bools = new bool[current.Count + after.Count];
            current.CopyTo(bools, 0);
            after.CopyTo(bools, current.Count);
            return new BitArray(bools);
        }

        public static byte[] getBytes(this BitArray bitArray)
        {
            if (bitArray.Count % 8 != 0)
                throw new ArgumentException("Bits count should be multiple of 8");

            byte[] bytes = new byte[bitArray.Length / 8];
            bitArray.CopyTo(bytes, 0);
            return bytes;
        }

        public static bool[] getRange(this BitArray bitArray, int start, int count)
        {
            var end = start + count - 1;
            if (end >= bitArray.Length)
                throw new IndexOutOfRangeException();

            var bools = new bool[count];
            var pointer = 0;
            while (start <= end)
                bools[pointer++] = bitArray[start++];

            return bools;
        }

    }
}
