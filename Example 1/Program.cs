using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int baseNumber = 5;
            int exponent = 3;
            int result = 1;

            for (int i = 0; i < exponent; i++)
            {
                result *= baseNumber;
            }

            Console.WriteLine($"The result of {baseNumber} raised to the power of {exponent} is: {result}");

            Console.ReadLine();
        }
    }
}
