using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileHandling
{
    class Docter
    {
        public void Details()
        {
            FileStream file1 = new FileStream("C:\\test\\Myfile.txt", FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(file1);
            sw.WriteLine("Here are doctors details");
            sw.Close();
            file1.Close();
        }
    }
}
