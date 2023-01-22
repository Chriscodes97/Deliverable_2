/* 
 Author of Program: Chris Parrado
 Date: 1/22/2023
 Description: C# console application for calculating letter grades
*/

using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a numeric grade: ");

            try
            {

                decimal grade = decimal.Parse(Console.ReadLine());

                string letter;

                if (grade >= 90)
                {
                    letter = "A";
                    Console.WriteLine("Your expected letter grade for ISM 4300 is: " + letter);
                }
                else if (grade >= 80 && grade < 90)
                {
                    letter = "B";
                    Console.WriteLine("Your expected letter grade for ISM 4300 is: " + letter);
                }
                else if (grade >= 70 && grade < 80)
                {
                    letter = "C";
                    Console.WriteLine("Your expected letter grade for ISM 4300 is: " + letter);
                }
                else if (grade >= 60 && grade < 70)
                {
                    letter = "D";
                    Console.WriteLine("Your expected letter grade for ISM 4300 is: " + letter + ". " + "You are expected to fail the class.");
                }
                else
                {
                    letter = "F";
                    Console.WriteLine("Your expected letter grade for ISM 4300 is: " + letter + ". " + "You are expected to fail the class.");
                }
            }
            catch
            {
                Console.WriteLine("Please enter a numeric value");
            }
        }
    }
}