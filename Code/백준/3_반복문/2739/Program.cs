﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2739
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i < 10; i++)
                Console.WriteLine(n + " * " + i + " = " + n * i);
        }
    }
}
