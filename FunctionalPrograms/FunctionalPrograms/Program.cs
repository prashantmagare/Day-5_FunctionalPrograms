using System;

namespace Day5BasicPrograms
{
    internal class Program
    { 
         public class Power_Of_2
        {
            public void Power_Of_Two(int number)
            {
                int temp = number;
                int result = 1;
                while (number != 0)
                {
                    result *= 2;
                    number--;
                }
                Console.WriteLine($"Power of 2 ^ {temp} is : {result}");
          
            }
        
            public static void Main(string[] args)
            {
                Power_Of_2 p2 = new Power_Of_2(); //Create Object

                Console.WriteLine("Enter the number ");  //take inpute from user
                int number = Convert.ToInt32(Console.ReadLine());

                p2.Power_Of_Two(number); //Call Methode\
            }
        }
    }
}