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
        Console.WriteLine("welcome to Alex's Candy Store. Where we sell exactly three items, lollipops, candy bars, and gum");
        Console.WriteLine("");

      //explanation of the candy options
        Console.WriteLine("Please make a selection");
        Console.WriteLine("Enter 1 for a lollipop.");
        Console.WriteLine("Enter 2 for a candybar.");
        Console.WriteLine("Enter 3 for a pack of gum.");
      
        //Input for candy type
        int type = Convert.ToInt32(Console.ReadLine());

        //Explanation of the size options
        Console.WriteLine("");
        Console.WriteLine("Please select a size");
        Console.WriteLine("Enter 1 for regular");
        Console.WriteLine("Enter 2 for large");
        Console.WriteLine("Enter 3 for extra large");
      
        //Input for the day of the week
        int size = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("");


        double price = 0;
        double LOLLIPOP = 0.80;
        double CANDYBAR = 1.50;
        double HARDCANDY = 0.60;

        double REGULAR = 1;
        double LARGE = 1.5;
        double EXTRALARGE = 2;
        //Process: Function to tell the user to restart if the number is more than 7
        if (type == 1)
        {
           price = LOLLIPOP;
        }
        else if (type == 2)
        {
            price = HARDCANDY;
        }
        //If not eligible output “Not Eligible”
        else
        {
            price = CANDYBAR;
        }
        if (size == 1)
        {
          price = price * REGULAR;
        }
        else if (size == 1)
        {
          price = price * LARGE;
        }
        else
        {
          price = price * EXTRALARGE;
        }

        double total = price * 1.13;
        double tax = total - price; 
        
        Console.WriteLine("Your cost before tax is: $" + price.ToString("0.00"));
        Console.WriteLine("\nThe amount you pay in tax is: $" + tax.ToString("0.00"));
        Console.WriteLine("\nThe total cost is: $" + total.ToString("0.00"));
        
        Console.WriteLine("\nDone");
    }
}
