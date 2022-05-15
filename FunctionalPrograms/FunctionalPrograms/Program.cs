using System;

namespace Day5BasicPrograms
{
    internal class Program
    {
        public class Factor
        {

            public void Factor_Of_Number(int number)
            {

                for (int i = 1; i < number; i++)
                {
                    if (number % i == 0)
                    {
                        Console.WriteLine($"Factors of Given Number are: {i}");

                    }
                }
            }
            public static void Main(string[] args)
            {
                Factor p2 = new Factor(); //Create Object

                Console.WriteLine("Enter the number ");  //take inpute from user
                int number = Convert.ToInt32(Console.ReadLine());

                p2.Factor_Of_Number(number); //Call Methode\
            }
        }
    }
}