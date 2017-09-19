using FizzbuzzerClassLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoopFizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 50; i++)
            {
                Console.WriteLine(Fizzbuzz.Getvalue(i));
              
            }
            Console.ReadKey();
        }
    }
}
