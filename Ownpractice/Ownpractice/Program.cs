using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ownpractice
{
    class Program
    {
        public class AddM
        {
            public  int AddAndMultiply(int a, int b, int c)
            {
                return ((a + b) * c);
            }
            public static double farehnith(double cel)
            {
                double frnth;
                if(cel< -271.15)
                {
                    Console.WriteLine ("Temparature below absolute zero");
                }
                frnth = cel * 1.8 + 32;
                return frnth;

            }
            public static void  Arithmetic(int x,int y)
            {
                int add = x + y;
                int sub = x - y;
                int mul = x * y;
                double div;
                if(y !=0)
                {
                    div = x / (y);
                }
                else
                {
                    div= 0;
                }
                
            }



            static void Main(string[] args)
            {
                AddM am = new AddM();
               Console.WriteLine(am.AddAndMultiply(2, 3, 2));
                //Console.WriteLine(AddAndMultiply(2, 3, 2));   if we declare method as static then we can acess like this.

                Console.WriteLine(farehnith(0));
                farehnith(-300);
                Console.WriteLine(farehnith(28.5));

                Console.ReadKey();
            }
        }
    }
}
