﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Odd_Lines
{
    public class Program
    {
        public static void Main()
        {
            
            string[] text = File.ReadAllLines("../../input.txt");

            for (int i = 1; i < text.Length; i += 2)
            {
                File.AppendAllText("output.txt", text[i] + Environment.NewLine);
            }

        }
    }
}
