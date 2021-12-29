using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrctExample
{
    class ReverseString
    {
        static void Main(string[]args)
        {
            string str = Console.ReadLine();
            char[] ch = str.ToCharArray();
            string reversestring = string.Empty;
            int length, index;
            length = ch.Length - 1;
            index = length;
            while(index>-1)
            {
                reversestring = reversestring + ch[index];
                index--;
            }
            Console.WriteLine("Hello");
        }
        
    }
}
