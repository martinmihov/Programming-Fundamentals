using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace _02_ExamSecond
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string privMessagePattern = @"^(\d+)\s+?<->\s+?([A-Za-z0-9]+)$";
            string broadcastPattern = @"^([^0-9]+)\s+<->\s+?([A-Za-z0-9]+)$";

            string input = Console.ReadLine();

            List<string> privateMessagesList = new List<string>();
            List<string> broadcastList = new List<string>();

            Regex regexPrivate = new Regex(privMessagePattern);
            Regex regexBroadcast = new Regex(broadcastPattern);


            while (input != "Hornet is Green")
            {

                Match matchesPrivMessage = regexPrivate.Match(input);
                Match matchesBroadcast = regexBroadcast.Match(input);


                if (matchesBroadcast.Success)
                {
                    var broadcastMessage = matchesBroadcast.Groups[1].Value;
                    var frequancy = matchesBroadcast.Groups[2].Value;
                    
                    char[] array = frequancy.ToCharArray();

                    StringBuilder sbMessage = new StringBuilder();

                    StringBuilder resultBroadcast = new StringBuilder();
                    

                    for (int i = 0; i < array.Length; i++)
                    {
                        char let = array[i];
                        if (char.IsUpper(let))
                        {
                            let = char.ToLower(let);
                            sbMessage.Append(let);
                        }
                        else
                        {
                            let = char.ToUpper(let);
                            sbMessage.Append(let);
                        }
                    }
                    resultBroadcast.Append(sbMessage + " -> ");
                    resultBroadcast.Append(broadcastMessage);

                    broadcastList.Add(resultBroadcast.ToString());
                }
                else if (matchesPrivMessage.Success)
                {
                    var recipient = matchesPrivMessage.Groups[1].Value.Reverse();
                    var privateMessage = matchesPrivMessage.Groups[2].Value;
                    var reversedRecipient = new StringBuilder();
                    var privateResultMessage = new StringBuilder();

                    foreach (var item in privateMessage)
                    {
                        privateResultMessage.Append(item);

                    }

                    foreach (var item in recipient)
                    {
                        reversedRecipient.Append(item);
                    }

                    StringBuilder privateMessageString = new StringBuilder();

                    privateMessageString.Append(reversedRecipient + " -> ");
                    privateMessageString.Append(privateResultMessage);

                    privateMessagesList.Add(privateMessageString.ToString());

                }
                else
                {
                    input = Console.ReadLine();
                    continue;
                }
                
                input = Console.ReadLine();
            }

            Console.WriteLine("Broadcasts:");

            if (broadcastList.Count == 0)
            {
                Console.WriteLine("None");
            }
            else
            {
                foreach (var item in broadcastList)
                {
                    Console.WriteLine($"{item}");
                }
            }

            Console.WriteLine("Messages:");

            if (privateMessagesList.Count == 0)
            {
                Console.WriteLine("None");
            }
            else
            {
                foreach (var item in privateMessagesList)
                {
                    Console.WriteLine($"{item}");
                }
            }


        }
    }
}
