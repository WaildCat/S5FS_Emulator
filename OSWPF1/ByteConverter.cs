﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSWPF1
{
    static class ByteConverter
    {
        public static short ShortFromBytes(System.IO.FileStream fs, int byteArrSize)
        {
            byte[] byteArr = new byte[byteArrSize];
            for (int i = 0; i < byteArrSize; ++i)
                byteArr[i] = (byte)fs.ReadByte();
            return BitConverter.ToInt16(byteArr, 0);
        }

        public static int IntFromBytes(System.IO.FileStream fs, int byteArrSize)
        {
            byte[] byteArr = new byte[byteArrSize];
            for (int i = 0; i < byteArrSize; ++i)
                byteArr[i] = (byte)fs.ReadByte();
            return BitConverter.ToInt32(byteArr, 0);
        }
    }
}
