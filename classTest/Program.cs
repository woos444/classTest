using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "abcDefGhijK"+"  "+"Ddd";
            Console.WriteLine(str.ToLower());
            Console.WriteLine(str.ToUpper());
            Console.WriteLine(str.Contains("dd"));
            Console.WriteLine(str[0]);
            Console.WriteLine(str.IndexOf('f'));
            Console.WriteLine(str.Substring(str.IndexOf("Ddd")));

            PracticeC.pract2();
            Console.ReadLine();

        }
    }
}