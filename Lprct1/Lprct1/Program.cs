using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

/*
Write a C# Sharp program to create a new list from a given list of integers where each integer value is added to 2 and the result value is multiplied by 5

Sample input: 1, 2, 3 , 4
Output: 15 20 25 30
*/
namespace Lprct1
{
    class Program
    {
        static void show(int str)
        {
            str = str + 2;
            str = str * 5;
            
            Console.Write(str + " ");
        }
        static void Main(string[] args)
        {
            
            List<int> numbers = new List<int>();
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(4);
            Console.Write("Sample input:");
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
                
            }
            Console.Write("\nSample output:");
            numbers.ForEach(show);
            Console.ReadKey();
            

            
        }
    }
}
