using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Network
{
    class NetworkFile
    {
       public void NetworkDetails()
        {
            
            FileStream filestreamObj = new FileStream("C:\\test\\networklog.txt", FileMode.Open, FileAccess.Read);
            StreamReader srr = new StreamReader(filestreamObj);
            Console.Write("Id\t\tSource\t\t\tDestination\t\tDate\t\t\tStatus\t\tNetwork\n");
            string[] date1 = new string[12];
            int[] id = new int [12];

            while (srr.Peek()>0)
                {
                string line = srr.ReadLine();
                string[] values = line.Split(':');

                
                if (line != "")
                {
                    if (values.Length > 1)
                    { 
                        if(line.StartsWith("Date"))
                        {
                            string date = values[1].Split(' ')[0];
                            
                            
                              string  date= Console.Write(date + "\t\t");
                        }
                         else

                        for (int i = 0;i<= 12;i++)
                            id[i] = Convert.ToInt32(values[i]);
                         Console.Write(values[1]+"\t\t");
                    }
                }
                else
                {
                    Console.WriteLine();
                }
               
                

                

               
            }
            
        }
    }
}
