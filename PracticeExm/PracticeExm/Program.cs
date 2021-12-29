using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeExm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter string");
            string ostr = Console.ReadLine();
            string rstr = string.Empty;
            for(int i=ostr.Length-1;i>=0;i--)
            {
                rstr = rstr + ostr[i];
            }
            Console.WriteLine(rstr);
            Console.ReadLine();
        }
    }
}
