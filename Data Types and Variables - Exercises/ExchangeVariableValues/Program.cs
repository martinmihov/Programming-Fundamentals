﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeVariableValues
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            Console.WriteLine("Before:");
            Console.WriteLine("a = {0}",a);
            Console.WriteLine("b = {0}",b);
            int exchange = 0;
            exchange = a;
            a = b;
            b = exchange;
            Console.WriteLine("After:");
            Console.WriteLine("a = {0}",a);
            Console.WriteLine("b = {0}",b);

        }
    }
}
