using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautyP
{
    class Dates
    {
        public string datT { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Dates> Dates1 = new List<Dates>();
                Dates D = new Dates()
                {
                  datT = Console.ReadLine()
                };
            Dates1.Add(D);
            Appointment.Schedule(D.datT);
            //Appointment.Schedule("7/25/2019 13:45:00");
            Appointment.Display();
            Appointment.Haspassed("7/25/2019 13:45:00");

   
            

            Console.ReadKey();
        }
    }
}
