using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{


  
       
      
    
    class Student
    {
        int rollno,amount,feesPaid;
            double rem_amount;
        string name, course_joined;
        private static double servicetax = 12.3;

       
        public Student(int roll_no, int feesPaid,string name, string course_joined)
        {
           this.rollno= roll_no;
            this.feesPaid = feesPaid;
            this.name = name;
             this.course_joined= course_joined;
            
        }
        public int Payment(int amount)

        {
            int Amount = amount;
            feesPaid = feesPaid + Amount;
            return Amount;
        }
        public void Print()
        {
            Console.WriteLine("The Rollno is:" + rollno);
            Console.WriteLine("The Name  is:" + name);
            Console.WriteLine("The Course_joined is:" + course_joined);
            Console.WriteLine("The  amount paid is:" + feesPaid);
            //Console.WriteLine("The Remaining amount is:" + rem_amount);
        }
        

        public int TotalFee
        {
            get
            {

                if (course_joined == "ASP.NET")
                {
                    int total = 3000;
                    rem_amount = total + total * servicetax - amount;
                    return  (int)rem_amount;
                }
                else
                {
                    int total = 2000;
                    rem_amount = total + total * servicetax - amount;
                    return (int)rem_amount;
                }
            }

        }
        public int DueAmount
        {
            get
            {
              return TotalFee - feesPaid;
                
            }
        }
        public static double Servicetax
        {
            get
            {
                return servicetax;
            }
            set
            {
                servicetax = value;
            }
        }
       
       

        
       

    }
}
