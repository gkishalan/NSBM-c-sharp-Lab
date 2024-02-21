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

            //Defining the base and exponent 
            int baseNumber = 3;
            int exponent = 4;

            //Initilize the result to 1
            int result = 1;

            //Itarate exponent times
            for (int i = 0; i < exponent; i++)
            {
                //Multiply result by baseNumber in each itaration
                result *= baseNumber;
            }

            //Print the result 
            Console.WriteLine($"The result of {baseNumber} raised to the power of {exponent} is : {result}");

            Console.ReadLine();
        }
    }
}
