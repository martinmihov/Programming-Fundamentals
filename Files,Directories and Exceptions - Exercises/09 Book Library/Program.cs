using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Globalization;
namespace _09_Book_Library
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines(@"..\..\Input.txt");

            List<Book> library = new List<Book>();

            foreach (var line in lines)
            {
                Book aBook = new Book();
                string[] eachBook = line.Split().ToArray();

                string title = eachBook[0];
                string author = eachBook[1];
                string publisher = eachBook[2];
                DateTime releaseDate = DateTime.ParseExact(eachBook[3],"dd.MM.yyyy",CultureInfo.InvariantCulture);
                string isbn = eachBook[4];
                decimal price = decimal.Parse(eachBook[5]);

                aBook.Title = title;
                aBook.Author = author;
                aBook.Publisher = publisher;
                aBook.ReleaseDate = releaseDate;
                aBook.ISBN = isbn;
                aBook.Price = price;
                library.Add(aBook);
            }
            Dictionary<string, decimal> authorEarnings = new Dictionary<string, decimal>();
            foreach (var book in library)
            {
                if (!authorEarnings.ContainsKey(book.Author))
                {
                    authorEarnings[book.Author] = 0m;
                }
                authorEarnings[book.Author] += book.Price;
            }

            List<string> preOutput = new List<string>();

            foreach (var author in authorEarnings.OrderByDescending(p => p.Value).ThenBy(a => a.Key))
            {
                // Console.WriteLine($"{author.Key} -> {author.Value}");
                preOutput.Add("$"{ author.Key} -> { author.Value}");
            }
            

            File.WriteAllLines("output.txt", preOutput);

        }
    }
}
