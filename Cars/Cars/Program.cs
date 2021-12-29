using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    class Program
    {
        static void Main(string[] args)
        {
            AssemblyLine.SuccessRate(10);
            AssemblyLine.ProductionRatePerHour(6);
            AssemblyLine.WorkingItemsPerMinute(6);
            Console.ReadKey();
        }
    }
}
