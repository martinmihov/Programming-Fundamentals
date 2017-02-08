using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_UserLogs
{
    public class DictionariesExercise
    {
        public static void Main()
        {
            SortedDictionary<string,Dictionary<string,int>> userLogs = new SortedDictionary<string,Dictionary<string,int>>();

            string input = Console.ReadLine();
            
            while (input != "end")
            { 
                string[] token =input.Split(new char[] { ' ', '=' });

                int count = 0;

                string ip = token[1];
                string userName = token[5];

                if (!userLogs.ContainsKey(userName))
                {
                    userLogs[userName] = new Dictionary<string, int>();
                }
                if (!userLogs[userName].ContainsKey(ip))
                {
                    userLogs[userName].Add(ip, count);
                }
                userLogs[userName][ip]++;

                

                input = Console.ReadLine();
            }

            foreach (var user in userLogs)
            {
                Console.WriteLine($"{user.Key}: ");

                foreach (var ip in user.Value)
                {

                    if (ip.Key != user.Value.Keys.Last())
                    {
                        Console.Write($"{ip.Key} => {ip.Value}, ");
                    }
                    else
                    {
                        Console.WriteLine($"{ip.Key} => {ip.Value}.");
                    }
                }
            }
        }
    }
}
