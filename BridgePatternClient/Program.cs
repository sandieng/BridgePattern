using BridgePattern;
using System;

namespace BridgePatternClient
{
    class Program
    {
        static void Main(string[] args)
        {
            // Decouple an abstraction from its implementation so that the two can vary independently.
            // Publish interface in an inheritance hierarchy, and bury implementation in its own inheritance hierarchy.
            var formatter = new StandardFormatter();
            var normalBook = new Book(formatter)
            {
                Title = "A Brief History on Mankind",
                Description = "A good introduction to the history of mankind from stone age to present day.",
                TotalPages = "500",
                YearPublished = "1998"
            };
            normalBook.Print();

            Console.WriteLine("==========================================================================");

            var crypticFormatter = new CrypticFormatter();
            var crypticBook = new Book(crypticFormatter)
            {
                Title = "Opium War: Why China Lost the War",
                Description = "In-depth analysis on the first and second opium war.",
                TotalPages = "365",
                YearPublished = "2012"
            };
            crypticBook.Print();

            Console.ReadKey();
        }
    }
}
