using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Write a C# Sharp program to remove all "a" in each string in given list of strings and return the new string

Sample input:"abc", "cdaef", "js" , "php"
Output: bc cdef js php
*/

namespace Lprct3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> stringlst = new List<string>();
            stringlst.Add("abc");
            stringlst.Add("cdaef");
            stringlst.Add("js");
            stringlst.Add("php");
            //stringlst = stringlst.Select(s => s.Replace("a", string.Empty)).ToList();

            foreach(string str in stringlst)
            {
                //stringlst = stringlst.Select(s => s.Replace("a", string.Empty)).ToList();

                Console.Write(str + " ");
                Console.ReadKey();
            }

        }
    }
}
