using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Fix_Emails
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<string, string> mailOwners = new Dictionary<string, string>();
            string seq = Console.ReadLine();
            while (seq != "stop")
            {
                string name = seq;
                string[] eMail = Console.ReadLine().Split('.');


                if (!mailOwners.ContainsKey(name))
                {
                    mailOwners[name] = string.Empty;
                }
                

                foreach (var item in mailOwners)
                {
                    Console.WriteLine($"{item.Key} -> {item.Value}");
                }
                seq = Console.ReadLine();
            }
        }
    }
}
