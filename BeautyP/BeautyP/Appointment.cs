using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautyP
{
    class Appointment
    {

       
           public static string DateT,Dtme;
       
        // public  static string Schedule(string tid,string tname,DateTime start,DateTime end,string sts)
        public static string Schedule(string datetime)
        {
            DateT = datetime;
            
            // Tid = tid;
            // Tname = tname;
            //Start = start;
            //End = end;
            //Sts = sts;
            return DateT;
            
        }
        public static void Display()
        {
            Console.WriteLine(DateT);
        }
        public static Boolean Haspassed(string dtme)
        {
            Dtme = dtme;
            if (DateT == Dtme)
            {
                Console.WriteLine("True");

            }
            else
                Console.WriteLine("False");
                

            return true;
            
           
        }
       
       
       

    }
}
