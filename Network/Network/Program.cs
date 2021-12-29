using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Network
{
    class Program
    {
        static void Main(string[] args)
        {
            NetworkFile nf = new NetworkFile();
            nf.NetworkDetails();
            Console.ReadKey();
        }
    }
}
