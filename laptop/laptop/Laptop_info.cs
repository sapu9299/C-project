using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laptop
{
    class Laptop_info
    {
        protected string name,processor,ram,harddrive;
        protected int price;
        
        public void GetData()
        {
            Console.WriteLine("\nWrite all the details for laptop");
            name = Console.ReadLine();
            processor = Console.ReadLine();
            ram = Console.ReadLine();
            harddrive = Console.ReadLine();
            price = Convert.ToInt32(Console.ReadLine());
        }
    }
}
