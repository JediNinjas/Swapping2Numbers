// James Prochaska
// 2.15.18
// This is a program that allows the user to enter numbers for two variables, and then 
// the program swaps the variables set values.

using System;
using System.Globalization;

namespace Task1_1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Creating variables 1 and 2
            int num1 = 0;
            int num2 = 0;
            bool worked = true;

            // Asking the user for input and calling .ToInt32 which converts the input from user into an interger
            Console.WriteLine("Place an integer value for number 1: ");        
                do
                {
                try { num1 = Convert.ToInt32(Console.ReadLine()); worked = true; }
                catch { Console.WriteLine("That is not an integer! Please enter a number: "); worked = false; }
                } while (!worked);
            Console.WriteLine("Good Job! Now, place an interger value for number 2: ");
                do
                {
                try { num2 = Convert.ToInt32(Console.ReadLine()); worked = true; }
                catch { Console.WriteLine("That is not an integer! Please enter a number: "); worked = false; }
            } while (!worked);

            // Printing out what the numbers are now equal to!
            Console.WriteLine("Number 1 is equal to: " + num1);
            Console.WriteLine("Number 2 is equal to: " + num2);
            Console.WriteLine("\nOkay, Now lets reverse the numbers!");

            // adding both variables and assigning it to num1
                num1 = num1 + num2;

            // now I am subtracting the added variable1 with variable 2 for variable2's new value
                num2 = num1 - num2;

            // subtracting both new variable values to finally have both variable values reversed
                num1 = num1 - num2;  

            // Swapped number values printed out
            Console.WriteLine("\nNumber 1 is now equal to: " + num1);
            Console.WriteLine("Number 2 is now equal to: " + num2);             
        }
    }
}
