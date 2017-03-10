using System;
using System.Text;

namespace _07_Multiply_big_numbers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string firstLine = Console.ReadLine().TrimStart(new char[] { '0' });
            int number = int.Parse(Console.ReadLine());

            
            int sum = 0;
            int remainder = 0;
            int numberInMind = 0;

            StringBuilder sb = new StringBuilder();

            for (int i = firstLine.Length - 1; i >= 0; i--)
            {
                sum = (int.Parse(firstLine[i].ToString()) * number) + numberInMind;
                remainder = sum % 10;
                numberInMind = sum / 10;
                sb.Append(remainder);
                if (i == 0 && numberInMind != 0)
                {
                    sb.Append(numberInMind);
                }
            }

            char[] result = sb.ToString().ToCharArray();
            Array.Reverse(result);


            if(number == 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine(new string(result));
            }
        }
    }
}
