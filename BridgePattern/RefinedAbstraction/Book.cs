using System;

namespace BridgePattern
{
    public class Book : Manuscript
    {
        private IPrintFormatter _formatter;


        // Each print method has its own implementation
        public Book(IPrintFormatter formatter)
        {
            _formatter = formatter;
        }

        // Decouple an abstraction from its implementation so that the two can vary independently.
        // Publish interface in an inheritance hierarchy, and bury implementation in its own inheritance hierarchy.
        public override void Print()
        {
            Console.WriteLine(_formatter.Format("Title", Title));
            Console.WriteLine(_formatter.Format("Description", Description));
            Console.WriteLine(_formatter.Format("TotalPages", TotalPages));
            Console.WriteLine(_formatter.Format("Year", YearPublished));
        }
    }
}
