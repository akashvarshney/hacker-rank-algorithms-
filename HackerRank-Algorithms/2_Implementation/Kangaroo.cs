using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Kangaroo {

    static void Main(String[] args) {
        string[] tokens_x1 = Console.ReadLine().Split(' ');
            int x1 = Convert.ToInt32(tokens_x1[0]);
            int v1 = Convert.ToInt32(tokens_x1[1]);
            int x2 = Convert.ToInt32(tokens_x1[2]);
            int v2 = Convert.ToInt32(tokens_x1[3]);

            for (int i = 0; i < 10000; i++)
            {
                if (x1 == x2)
                {
                    Console.WriteLine("YES");
                    break; 
                }
                else
                {
                    x1 = x1 + v1;
                    x2 = x2 + v2;
                }
            }
            if (x1 != x2)
            {
                Console.WriteLine("NO");
            }
    }
}
