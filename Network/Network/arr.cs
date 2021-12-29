using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Network
{
    class arr
    {
        string[] date1 = new string[12];
        int[] id1 = new int[12];
        string[] source = new string[12];
        string[] destination = new string[12];
        string[] network = new string[12];
        public void arrymthd()
        {
            for (int i = 0; i <= 12; i++)
            {
                id1[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i <= 12; i++)
            {
                Console.WriteLine("ID:", id1[i]);
            }
        }
    }
}
