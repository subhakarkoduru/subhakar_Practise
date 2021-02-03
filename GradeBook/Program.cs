using Gradebook;
using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("scott");
            book.Addgrade(20.14);
            book.Addgrade(50.16);
            book.showstaistics();

            
        }
    }
}
