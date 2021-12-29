using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Stack1
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack myStack = new Stack();
             
            for(int i=0;i<=2;i++)
            {
                string name = Console.ReadLine();
                int age = Convert.ToInt32(Console.ReadLine());
                myStack.Push(new Person() { Name = name, Age = age });    
            }
            foreach(Person p in myStack)
            {
                Console.WriteLine(p.ToString());
            }
            Console.ReadLine();

        }
    }
}
