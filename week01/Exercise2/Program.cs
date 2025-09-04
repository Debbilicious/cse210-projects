using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage? ");
        string answer = Console.ReadLine();
        int grade = int.Parse(answer);

        string letter = "";
        string sign = "";

        if (grade >= 90)
        {
            letter = "A";
        }

        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You passed the class!");
        }
        else
        {
            Console.WriteLine("Better luck next time.");
        }

        // Stretch Challenge: Add + or - to the letter grade
        int lastDigit = grade % 10;
        if (letter != "F")
        {

            if (letter == "A")
            {
                if (lastDigit < 3)
                    sign = "-";
            }
            else
            {
                if (lastDigit >= 7)
                    sign = "+";
                else if (lastDigit < 3)
                    sign = "-";
            }
        }


        // Display the final grade with sign
        Console.WriteLine($"Your grade is: {letter}{sign}");
    }
}

    
