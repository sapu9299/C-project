using System;
//Write a C# Sharp program that takes three letters as input and display them in reverse order.
namespace PhotoAlbum
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("enter one value");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("value of a:"+a);
            Console.WriteLine("Enter any string");
            string b = Console.ReadLine();
            Console.WriteLine("character is:" +b);
            Console.WriteLine("Enter any character/letter");
            char c = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Character is:" + c);
           
        }
    }
}
