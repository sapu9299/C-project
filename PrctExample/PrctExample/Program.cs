using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrctExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            input = input.Replace("  ", string.Empty);//right
            Console.WriteLine(input);

            for (int i = 0; i<input.Length; i++)
            {
                Console.WriteLine(input[0]+ "=");
                int count = 0;
                for(int j=0;j<input.Length;j++)
                {
                    if(input[0]==input[j])
                    {
                        count++;
                    }
                }
                Console.WriteLine(count);
                input.Replace(input[0].ToString(), string.Empty);
            }
            Console.ReadKey();
        }
    }
}
