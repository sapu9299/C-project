using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Arrylist
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList prlist = new ArrayList();
            Console.WriteLine("Enter persons Details");
            /*
            object name = Console.ReadLine();
            object id = Console.ReadLine();
            prlist.Add(name);
            prlist.Add(id);
            */

              for (int i = 0; i <= 2; i++)
              {
                /*
                  string name = Console.ReadLine();
                  prlist.Add(name);

                  //Console.WriteLine(name);
                  string id = Console.ReadLine();
                  prlist.Add(id);
                  //Console.WriteLine(id);
                */

             object name = Console.ReadLine();
            object id = Console.ReadLine();
            prlist.Add(name);
            prlist.Add(id);
            }
            



            foreach (object obj in prlist)
            {
                Console.WriteLine(obj.ToString());
                

            }

            Console.ReadLine();


          
        }
    }
}
