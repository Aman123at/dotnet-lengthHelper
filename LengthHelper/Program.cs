using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LengthHelper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Length finder project");

            Console.WriteLine("Enter your string to find length");

            // taking user input in console using ReadLine method
            string mystr = Console.ReadLine();
            
            // taking return value of findLength method in a variable
            int length = findLength(mystr);

            // using template literal to inject variable's value in string
            Console.WriteLine($"Length of string is : {length}");

            // using ReadKey method to show the output in console
            Console.ReadKey();
        }


        // findLength Method to calculate length of string
        static int findLength(string s)
        {
            return s.Length;
        }
    }
}
