using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleIntrfce
{
    interface Iemployee
    {
       
        //by default public,abstract
        
         void Show();
        
    }
    interface Gemployee
    {
        void Show();
    }
    class PartTimeEmployee : Iemployee,Gemployee
    {
         void Iemployee.Show()
        {
            Console.WriteLine("this is method for Iemployee interface !!");

        }
        void Gemployee.Show()
        {
            Console.WriteLine("this is method for Gemployee interface !!");
        }
    }
}
