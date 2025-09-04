using System;
using System.Collections.Generic;

class Program
{
     static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int input;

        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");

        // Read numbers from user until they enter 0
        do
        {
            Console.Write("Enter number: ");
            input = int.Parse(Console.ReadLine());
            
            if (input != 0)
            {
                numbers.Add(input);     
            }
        } while (input !=0);

        // Compute the sum
        int sum = 0;
        foreach (int num in numbers)
        {
          sum += num;  
        }

        // Compute the average
        double average = 0;
        if (numbers.Count > 0)
        {
            average = (double)sum / numbers.Count;
        }

        //Find the max
        int max = numbers[0];
        foreach (int number in numbers)
        {
          if (number > max) 
          {
            max = number;
          } 
        }

        // Display results

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The max is: {max}");

        // Stretch Challenge

        // Find the smallest positive number

        int smallestPositive = -1; // -1 means we haven't found a positive number yet
        foreach (int number in numbers)
        {
            if (number > 0)
            {
                if (smallestPositive == -1 || number < smallestPositive)
                {
                    smallestPositive = number;
                }
            }
        }
        if (smallestPositive != -1)
        {
            Console.WriteLine("The smallest positive number is: " + smallestPositive);
        }
        else
        {
            Console.WriteLine("No positive numbers were entered.");
        }

        // Sort the list
        numbers.Sort();
        Console.WriteLine("The sorted list is:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}

        


    


    

            


            
            
        