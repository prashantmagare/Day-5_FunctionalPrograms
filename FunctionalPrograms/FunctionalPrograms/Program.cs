using System;

namespace Day5BasicPrograms
{
    internal class Program
    { 
         public class Harmonic
        {
            public void HarmonicNum(int number)
            {
                double result = 0;
                for (int i = 1; i <= number; i++)
                {
                    result += 1 / (float)i;
                    //result = result + 1 / i;
                }
                Console.WriteLine($"Harmonic Number of given number is :{result}");

            }
        
            public static void Main(string[] args)
            {
                Harmonic h = new Harmonic(); //Create Object

                Console.WriteLine("Enter the number ");  //take inpute from user
                int number = Convert.ToInt32(Console.ReadLine());

                h.HarmonicNum(number); //Call Methode\
            }
        }
    }
}