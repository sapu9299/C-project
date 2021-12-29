using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student("Sapana","Bais", "ytl",1232);
            s.calculate();
            s.Display();
            Console.ReadKey();
        }
    }
}
