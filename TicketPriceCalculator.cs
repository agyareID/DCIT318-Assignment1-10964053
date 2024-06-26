using System;

class Program
{
    static void Main()
    {
        Console.Write("Welcome To The Movie Theater!!!\nBefore You Get A Ticket.\nEnter your age: ");
        string input = Console.ReadLine();
        int age;
        
        
        if (int.TryParse(input, out age) && age >= 0)
        {
            int ticketPrice = CalculatePrice(age);
            Console.WriteLine($"The ticket price is: GHC{ticketPrice}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid age.");
        }
    }

    static int CalculatePrice(int age)
    {
        const int originalPrice = 10;
        const int discountPrice = 7;

        if (age <= 12 || age >= 65)
        {
            return discountPrice;
        }
        else
        {
            return originalPrice;
        }
    }
}
