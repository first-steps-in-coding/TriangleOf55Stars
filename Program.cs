﻿using System;


namespace TriangleOf55Stars
{
    class Program
    {
        static void Main()
        {
            int val = 10;
            int i, j, k;
            for (i = 1; i <= val; i++)
            {
                for (j = 1; j <= val - i; j++)
                {
                    
                }
                for (k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
           
        }
    }

  }

