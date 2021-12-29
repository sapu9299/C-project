using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Student:Person
    {
        string fname,lname, city;
        int id, sum = 0, marks,ns,avg;
        
        
       public  Student(string fname,string lname,string city,int id)
        {
             this.fname = fname;
              this.lname = lname;
            this.city = city;
            this.id = id;
            
           

        }
        public char calculate()
        {
            ns = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < ns; i++)
            {
                
                marks = Convert.ToInt32(Console.ReadLine());
                sum = sum + marks;


            }
            avg = sum / ns;
            //Console.WriteLine("Total grade:" + avg);
            
            return 'a';

        }
        public void Display()
        {
            Console.Write("Name:"+lname);
            Console.WriteLine(","+fname);
            Console.WriteLine("ID:"+id);
            if (avg >= 90 && avg <= 100)
            {
                Console.WriteLine("Grade:O");
            }
            else if (avg >= 80 && avg < 90)
            {
                Console.WriteLine("Grade:E");
            }
            else if (avg >= 70 && avg < 80)
            {
                Console.WriteLine("Grade:A");
            }
            else if (avg >= 55 && avg < 70)
            {
                Console.WriteLine("Grade:P");
            }
            else if (avg >= 40 && avg < 55)
            {
                Console.WriteLine("Grade:D");
            }
            else
            {
                Console.WriteLine("Grade:T");
            }
            
        }
    }
}
