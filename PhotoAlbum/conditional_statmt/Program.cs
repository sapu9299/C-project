﻿using System;

namespace conditional_statmt
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=5, b=6;
            if(a>b)
            {
                Console.WriteLine("a is greater");
            }
            if (b > a)
            {
                Console.WriteLine("b is greater");
            }
            else
                Console.WriteLine("Both are equal");
        }
    }
}
