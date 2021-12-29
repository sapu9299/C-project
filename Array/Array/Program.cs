using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
             int num = Convert.ToInt32(Console.ReadLine());
             for (int i=0;i<num;i++)
             {

                 Console.Write("element {0}" +i);
             }
            */
            int[] intArr = new int[5];
            Console.WriteLine("Enter 5 elements in an array:\n");
            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine("element {0}", i);
                intArr[i] = Convert.ToInt32(Console.ReadLine());
            }
                Console.WriteLine("\nElements in an array are:");
                for (int i = 0; i <= 4; i++)
                {
                    Console.WriteLine(" {0}", intArr[i]);
                }
            
            Console.Write("\n");
        }
    }
}
