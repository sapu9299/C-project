using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Write a C# Sharp program to create a new list from a given list of strings where each element is replaced by 4 copies of the string concatenated together

Sample input: "1", "2", "3" , "4"
Output: 1111 2222 3333 4444
*/
namespace Lprct2
{
    class Program
    {
        static void display(string str)
        {
            str = str + str + str+str;
            Console.Write(str+" ");

        }
        static void Main(string[] args)
        {
            List<string> numbers = new List<string>();
            numbers.Add("1");
            numbers.Add("2");
            numbers.Add("3");
            numbers.Add("4");

            numbers.ForEach(display);
            Console.ReadKey();
        }
        
    }
}
