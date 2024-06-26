using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter Your Score (0-100): ");
        string input = Console.ReadLine();
        int score;
        
        
        if (int.TryParse(input, out score) && score >= 0 && score <= 100)
        {
            string Grade = GetGrade(score);
            Console.WriteLine($"Your grade is: {Grade}");
        }
        else
        {
            Console.WriteLine("Wrong input. Please enter a number between 0 and 100.");
        }
    }

    static string GetGrade(int score)
    {
        if (score >= 90)
        {
            return "A";
        }
        else if (score >= 80)
        {
            return "B";
        }
        else if (score >= 70)
        {
            return "C";
        }
        else if (score >= 60)
        {
            return "D";
        }
        else
        {
            return "F";
        }
    }
}
