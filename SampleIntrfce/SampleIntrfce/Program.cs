using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleIntrfce
{
    
    class Program
    {
        static void Main(string[] args)
        {
            PartTimeEmployee pte = new PartTimeEmployee();
            //pte.Show();
            ((Iemployee)pte).Show();   //converting object to interface reference variable
            ((Gemployee)pte).Show();
            //or
            Iemployee obj1 = new PartTimeEmployee();
            obj1.Show();
            Gemployee obj2 = new PartTimeEmployee();
            obj2.Show();
            Console.ReadLine();
        }
    }
}
