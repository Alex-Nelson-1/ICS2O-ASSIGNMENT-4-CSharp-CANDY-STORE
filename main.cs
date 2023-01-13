// Created by: Alex Nelson
// Created on: Nov 2022
//
// This program tells you which age range of movies you can
using System;

class Program
{
    public static void Main(string[] args)
    {
        //Explanation of the algorithm
        Console.WriteLine("Students between 12 and 21 receive a discount to the museum on weekdays. Enter in your age and the day you're visiting the museum below ");
        Console.WriteLine("");
        Console.WriteLine("Please enter your age");
        //Input for user’s age
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("");
        Console.WriteLine("Please enter the day as a number(Monday being 1, and Sunday being 7)");
        //Input for the day of the week
        int day = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("");
        //Process: Function to tell the user to restart if the number is more than 7
        if (day > 7)
        {
            Console.WriteLine("You have input something incorrectly. Please relaunch code.");
        }
        else if ((age > 12 && age < 21) && (day != 6 && day != 7))
        {
            //If eligible output “Eligible”
            Console.WriteLine("Eligible!");
        }
        //If not eligible output “Not Eligible”
        else
        {
            Console.WriteLine("Not Eligible!");
        }
        Console.WriteLine("\nDone");
    }
}
