using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;


namespace RegExp
{
    class Program
    {
        static void Main(string[] args)
        {
            //DATE PATTERN month date
 
            string patternText = @"([a-zA-Z]+) (\d+)";  //july 12
            string input = "the christmas day is celebrated on December 25 and new year on jan 1";

            Match match = Regex.Match(input,patternText);

            if (match.Success)
            {
                Console.WriteLine(match.Value);
            }
            Regex reg = new Regex(patternText);
            Console.WriteLine(reg.IsMatch(input));


            MatchCollection collection = Regex.Matches(input, patternText);
            foreach (Match m in collection)
            {
                Console.WriteLine(m.Value);
            }


            // PHONE NUMBER  PATTERN  1234 - 9876
            //string pattern = @"(\d+)-(\d+)";
            //string input1 = " 91-787898";
            ////kjdl91-787898 it will take.... soln to this  @"^(\d+)-(\d+)$";
            //Match match1 = Regex.Match(input1, pattern);
            //Console.WriteLine(match1.Value);
            //if (match1.Success)
            //{
            //    Console.WriteLine("phone number is valid");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid Phone number");
            //}

            // EMAIL PATTERN alphanumericcharacter =12345 a-z A-Z  sapna7878 78787sapna  sapana787@gmail.com
            string Pattern2 = @"^(\w+)@(\w+).([a-z]+)$";
            string input2 = "sapanarbais@gmail.com";
            Match match2 = Regex.Match(input2, Pattern2);
            if (match2.Success)
            {
                Console.WriteLine("Valid Email Address");
            }
            else
            {
                Console.WriteLine("Invalid Email Address");
            }
            Console.ReadKey();

        }
    }
}
