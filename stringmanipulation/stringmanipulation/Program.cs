using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringmanipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "hello";
            int alpha = 0, digit = 0, ch = 0, i = 0;
            int s1 = str1.Length - 1;
            while (i < s1)
            {
                if ((str1[i] >= 'a' && str1[i] <= 'z') || (str1[i] >= 'A' && str1[i] <= 'Z'))
                {
                    alpha++;
                }

                else if (str1[i] >= '0' && str1[i] <= '9')
                {
                    digit++;
                }
                else
                {
                    ch++;
                }
                i++;
            }
            

            Console.WriteLine("number of words is: {0}\n", alpha);
            Console.WriteLine("number of digit={0}\n", digit);
            Console.WriteLine("number of character={0}\n", ch);
            Console.ReadLine();

        }
    }
}
