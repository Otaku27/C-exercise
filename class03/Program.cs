using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class03
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Raynor");
            book.AddGrade(60.0);
            book.AddGrade(70.0);
            book.AddGrade(80.0);
            book.Show();
            book.LowandHigh();
            Console.WriteLine( book.Find());
            Console.ReadKey();
        }
    }
}
