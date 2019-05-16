using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the sequence number for the prime number you'd like to locate: ");
            string input = Console.ReadLine();

            int num = int.Parse(input);

            Console.WriteLine(Method.GetPrime(num));



        }
    }
}
