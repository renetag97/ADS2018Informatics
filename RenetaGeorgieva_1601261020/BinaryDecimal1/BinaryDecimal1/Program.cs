﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryDecimal1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int num, binary_val, decimal_val = 0, base_val = 1, rem;
            Console.Write("Enter a Binary Number(1s and 0s) : ");
            num = int.Parse(Console.ReadLine());
            binary_val = num;
            while (num > 0)
            {
                rem = num % 10;
                decimal_val = decimal_val + rem * base_val;
                num = num / 10;
                base_val = base_val * 2;
            }
            Console.Write("The Binary Number is : " + binary_val);
            Console.Write("\nIts Decimal Equivalent is : " + decimal_val);
            Console.ReadLine();
        }
    }
}

