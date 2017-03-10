using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Sum_big_numbers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string firstLine = Console.ReadLine().TrimStart(new char[] { '0' });
            string secondLine = Console.ReadLine().TrimStart(new char[] { '0' });
            
            if (firstLine.Length > secondLine.Length)
            {
                secondLine = secondLine.PadLeft(firstLine.Length, '0');
            }
            else
            {
                firstLine = firstLine.PadLeft(secondLine.Length, '0');
            }

            int sum = 0;
            int remainder = 0;
            int numberInMind = 0;

            StringBuilder sb = new StringBuilder();
            
            for (int i = firstLine.Length - 1; i >= 0; i--)
            {
                sum = int.Parse(firstLine[i].ToString()) + int.Parse(secondLine[i].ToString()) + numberInMind;
                remainder = sum % 10;
                numberInMind = sum / 10;
                sb.Append(remainder);
                if(i == 0 && numberInMind != 0)
                {
                    sb.Append(numberInMind);
                }
            }

            char[] result = sb.ToString().ToCharArray();
            Array.Reverse(result);


            Console.WriteLine(new string (result));
        }
    }
}
