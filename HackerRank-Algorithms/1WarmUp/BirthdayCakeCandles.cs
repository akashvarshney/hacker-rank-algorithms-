﻿using System;

namespace HackerRank.Algorithms.Warmup
{
    public class ClsBirthdayCakeCandles
    {
        static int birthdayCakeCandles(int n, int[] ar)
        {
            int heighestNumber = ar[0];
            int count = 0;
            string str = string.Empty;
            // find heigest number
            for (int i = 0; i < ar.Length; i++)
            {
                if (heighestNumber < ar[i])
                {
                    heighestNumber = ar[i];
                }
            }
            // find occurance of heigest number
            for (int i = 0; i < ar.Length; i++)
            {
                if (heighestNumber == ar[i])
                {
                    count++;
                }
            }
            return count;
        }
        public static void Call()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] ar_temp = Console.ReadLine().Split(' ');
            int[] ar = Array.ConvertAll(ar_temp, Int32.Parse);
            int result = birthdayCakeCandles(n, ar);
            Console.WriteLine(result);
            Console.Read();
        }
    }
}
