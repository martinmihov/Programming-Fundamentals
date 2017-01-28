using System;

namespace LastKNumbersSum
{
    public class Arrays
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            long[] sequence = new long[n];
            sequence[0] = 1;

            for (int iSeq = 0; iSeq < n; iSeq++)
            {
                long result = 0;

                for (int prevSeq = iSeq; prevSeq >= 0 && prevSeq >= iSeq - k; prevSeq--)
                {
                    result += sequence[prevSeq];
                }
                sequence[iSeq] = result;
            }
            Console.WriteLine(String.Join(" ",sequence).Trim());
        }
    }
}
