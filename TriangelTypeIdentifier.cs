using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("## Identify Triangles! ##\nWhen prompted for length of side\nEnter values Between 1 & 2 including decimal notations.\nEqual values for all side = Equilateral\nEqual values for two sides = Isosceles\nNo Equal Values for sides =  Scalene\n\n ");
        double side1 = GetSideLength("Enter the length of side 1: ");
        double side2 = GetSideLength("Enter the length of side 2: ");
        double side3 = GetSideLength("Enter the length of side 3: ");

        if (IsValidTriangle(side1, side2, side3))
        {
            string triangleType = DetermineTriangleType(side1, side2, side3);
            Console.WriteLine($"This is: {triangleType}");
        }
        else
        {
            Console.WriteLine("The lengths entered do not form a valid triangle.");
        }
    }

    static double GetSideLength(string prompt)
    {
        double side;
        while (true)
        {
            Console.Write(prompt);
            if (double.TryParse(Console.ReadLine(), out side) && side > 0 && side <= 2)
            {
                return side;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a positive number.");
            }
        }
    }

    static bool IsValidTriangle(double side1, double side2, double side3)
    {
        // Check the triangle inequality theorem
        return side1 + side2 > side3 && side1 + side3 > side2 && side2 + side3 > side1;
    }

    static string DetermineTriangleType(double side1, double side2, double side3)
    {
        // Check if it's an equilateral triangle
        if (side1 == side2 && side2 == side3)
        {
            return " An Equilateral Triangle";
        }
        // Check if it's an isosceles triangle
        else if (side1 == side2 || side2 == side3 || side1 == side3)
        {
            return "An Isosceles Triangle";
        }
        // Otherwise, it's a scalene triangle
        else
        {
            return "A Scalene Triangle";
        }
    }
}
