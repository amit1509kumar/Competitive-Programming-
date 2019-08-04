using System;
using System.Collections.Generic;
using System.Text;

namespace Competitive_Programming
{
    public class Reader
    {
        public static int[] ReadArray()
        {
            return Array.ConvertAll(Console.ReadLine().Split(' '), m => Convert.ToInt32(m));
        }

        public static int ReadInt()
        {
            return Convert.ToInt32(Console.ReadLine());
        }

        public static string ReadStr()
        {
            return Console.ReadLine();
        }

        public static long ReadLong()
        {
            return Convert.ToInt64(Console.ReadLine());
        }

        public static long[] ReadLongArray()
        {
            return Array.ConvertAll(Console.ReadLine().Split(' '), m => Convert.ToInt64(m));

        }
    }
}
