using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {

            
            Student s = new Student(21, 200, "Sapana", "ASP.NET");
            s.Payment(500);
            
            s.Print();
            Console.WriteLine(s.DueAmount);

            Console.ReadKey();
        }
    }
}
