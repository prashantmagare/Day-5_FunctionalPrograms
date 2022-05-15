using System;

namespace Day5BasicPrograms
{
    internal class Program
    { 
            public class Quoitent_And_Remainder
            {
                public void Quoitent_and_Remainder(double number)
                {
                    double Remainder = number % 2;
                    double Quoitent = number / 2;
                    Console.WriteLine($"Remainder of given number is : {Remainder}");
                    Console.WriteLine($"Quoitent of given number is : {Quoitent}");
                }

            }

            public static void Main(string[] args)
            {
                Quoitent_And_Remainder qandr = new Quoitent_And_Remainder(); //Create Object

                Console.WriteLine("Enter the number ");  //take inpute from user
                double number = Convert.ToDouble(Console.ReadLine());

                qandr.Quoitent_and_Remainder(number); //Call Methode\
            }
        }
    }
