using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_FixEmails
{
    public class DictionariesExercise
    {
        public static void Main(string[] args)
        {
            Dictionary<string, string> mailOwners = new Dictionary<string, string>();

            string input = Console.ReadLine();

            while (input != "stop")
            {
                string name = input;
                string eMail = Console.ReadLine();

                if (!mailOwners.ContainsKey(name))
                {
                    mailOwners[name] = string.Empty;
                }
                mailOwners[name] += eMail;

                input = Console.ReadLine();
            }

            var fixedMails = mailOwners.Where(o => !o.Value.ToLower().EndsWith("us") && !o.Value.ToLower().EndsWith("uk"))
                .ToDictionary(p => p.Key , p => p.Value);

            foreach (var mail in fixedMails)
            {
                Console.WriteLine($"{mail.Key} -> {mail.Value}");
            }
        }
    }
}
