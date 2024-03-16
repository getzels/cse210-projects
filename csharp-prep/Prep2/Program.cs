using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade percentage: ");
        int grade = int.Parse(Console.ReadLine());

        string letterGrade = ""; // Initialize the letter grade variable
        string sign = ""; // Initialize the sign variable

        // Determine the letter grade
        if (grade >= 90)
        {
            letterGrade = "A";
        }
        else if (grade >= 80)
        {
            letterGrade = "B";
        }
        else if (grade >= 70)
        {
            letterGrade = "C";
        }
        else if (grade >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }

        // Determine the sign for grades A-D
        if (grade >= 60 && grade < 90) // Exclude A and F from having signs
        {
            int lastDigit = grade % 10;
            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
        }

        // Handle the exceptional cases for A and F
        if (letterGrade == "A" && grade < 93)
        {
            sign = "-";
        }
        else if (letterGrade == "F")
        {
            sign = ""; // Ensure no sign for F grades
        }

        // Print the final grade
        Console.WriteLine($"Your letter grade is: {letterGrade}{sign}");

        // Determine if the user passed the course
        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("You did not pass the course. Better luck next time!");
        }
    }
}
