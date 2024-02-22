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
            /*Write a function integer Power ( base , exponent ) that returns the value of base exponent for example , integer power ( 3, 4) = 3*3*3*3 . 
             * Assume that exponent is a positive , nonzero integer , an base is an integer . 
             * Function integer power should be used to control the calculation . 
             * Do not use any math library functions.*/
            //We can use 3 method for this question 

            //Using Math.Pow mathod

            // Define integer variables representing the base number and the exponent
            int baseNumber = 3;
            int exponent = 4;


            // Calculate the result of raising the base number to the power of the exponent
            // Note: Math.Pow method requires double type parameters, so we explicitly cast the integer variables to double
            double result = Math.Pow(baseNumber, exponent);

            // Display the result of the power operation
            Console.WriteLine($"The result of {baseNumber} raiesd to power of {exponent} is : {result}");

            // Wait for user input before closing the console window
            Console.ReadLine();
        }
    }
}
