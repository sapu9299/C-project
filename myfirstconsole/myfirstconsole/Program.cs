using System;

namespace myfirstconsole
{
    class Program
    {
        public void print()
        {

            Console.WriteLine("Welcome to new project!!!!!!");
        }
        static void Main(string[] args)
        {
            Program prog = new Program();
            prog.print();
            Console.ReadKey();
        }
    }
}
