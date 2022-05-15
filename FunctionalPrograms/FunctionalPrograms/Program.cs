using System;

namespace Day5BasicPrograms
{
    internal class Program
    {
        public class SwapNumber
        {
            int temp = 0;
            public void Swapping(int number1, int number2)
            {
                temp = number1;
                number1 = number2;
                number2 = temp;
                Console.WriteLine($"After Swapping number 1 : {number1} number 2 : {number2}");
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number1 and number2"); //take inpute from user

            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Before Swapping number1 : {number1} number 2 : {number2}"); //print N1 & N2

            SwapNumber swap = new SwapNumber(); //Create Object

            swap.Swapping(number1, number2); // Call method
        }
    }
}