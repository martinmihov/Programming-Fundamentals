using System;
using System.Collections.Generic;
using System.Linq;


class Book
{
    public string title { get; set; }
    public string author { get; set; }
    public string publisher { get; set; }
    public string releaseDate { get; set; }
    public string ISBNnumber { get; set; }
    public decimal price { get; set; }
}

class Library
{
    public string name { get; set; }
    public List<Book> books { get; set; }
}

public class BookLibrary
{
    public static void Main(string[] args)
    {
        Library myLibrary = new Library();
        myLibrary.books = new List<Book>();
        int numberOfBooks = int.Parse(Console.ReadLine());
        for (int book = 0; book < numberOfBooks; book++)
        {
            string[] data = Console.ReadLine().Split().ToArray();
            string title = data[0];
            string author = data[1];
            string publisher = data[2];
            string releaseDate = data[3];
            string ISBNnumber = data[4];
            decimal price = decimal.Parse(data[5]);
            Book myBook = new Book();
            myBook.title = title;
            myBook.author = author;
            myBook.publisher = publisher;
            myBook.releaseDate = releaseDate;
            myBook.ISBNnumber = ISBNnumber;
            myBook.price = price;
            myLibrary.books.Add(myBook);
        }

        Dictionary<string, decimal> filteredBooks = new Dictionary<string, decimal>();
        for (int book = 0; book < myLibrary.books.Count; book++)
        {
            if (!filteredBooks.ContainsKey(myLibrary.books[book].author))
            {
                filteredBooks.Add(myLibrary.books[book].author, 0);
            }
            filteredBooks[myLibrary.books[book].author] += myLibrary.books[book].price;
        }


        foreach (var book in filteredBooks.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
        {
            Console.WriteLine("{0:f2} -> {1:f2}", book.Key, book.Value);
        }

    }
}