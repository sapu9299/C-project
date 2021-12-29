using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
   public class AssemblyLine
    {
        static int value,Min;
        static double Hours;
        public static int SuccessRate(int num)
        {
            value = num;
            if(value==0)
            {
                Console.WriteLine("0%");
            }
            else if(value>1 && value<5)
            {
                Console.WriteLine("100%");
            }
            else if (value>4 && value<8)
            {
                Console.WriteLine("90%");
            }
            else if (value==8)
            {
                Console.WriteLine("80%");
            }
            else if ( value==10)
            {
                Console.WriteLine("77%");
            }
            return value;
        }
        public static double ProductionRatePerHour(int hours)
        {
            Hours = hours;
            Hours =  Hours*221;
            Console.WriteLine(Hours);
            return hours;
        }
        public static int WorkingItemsPerMinute(int min)
        {
            Min = min;
            
            Min = (Min*221)/60;
            Console.WriteLine(Min);
            return Min;
        }
    }
}
