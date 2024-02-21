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

            //Using loop method 

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
