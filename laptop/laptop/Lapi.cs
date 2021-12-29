using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laptop
{
    class Lapi :Laptop_info
    {
        public void Display()
        {
            Console.WriteLine("Name:" + name);
            Console.WriteLine("Price:" +price );
            Console.WriteLine("Processor:" +processor);
            Console.WriteLine("Ram:" + ram);
            Console.WriteLine("HDD:" + harddrive);
            Console.ReadKey();

        }
    }
}
