using System;

public class Hypotenus
{
    static double findHypotenuse(double side1, double side2){
        double h = Math.Sqrt((side1 * side1) + (side2 * side2));
        return h;
    }

    public static void Main(string[] args)
    {
        double side1, side2;

        Console.WriteLine("\n\n\t\tProgram to find hypotenuse of triangle.");

        Console.Write("\t\tSide 1: ");
        side1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("\t\tSide 2: ");
        side2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\t\tHypotenuse: {0:F2}", findHypotenuse(side1, side2));
        Console.WriteLine("\n\n");
    }
}