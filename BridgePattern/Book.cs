using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern
{
    public class Book : Manuscript
    {
        private IPrintFormatter _formatter;

        public Book(IPrintFormatter formatter)
        {
            _formatter = formatter;
        }

        public override void Print()
        {
            Console.WriteLine(_formatter.Format("Title", Title));
            Console.WriteLine(_formatter.Format("Description", Description));
            Console.WriteLine(_formatter.Format("TotalPages", TotalPages));
            Console.WriteLine(_formatter.Format("Year", YearPublished));
        }
    }
}
