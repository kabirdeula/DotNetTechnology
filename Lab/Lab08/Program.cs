//C# program to find the root of a Quadratic Equation.

using System;

class QuadRoot
{
    public static void ComputeRoot(double a, double b, double c)
    {   
        double root1   =   0;
        double root2   =   0;
        double eq      =   0;

        eq = b * b - 4 * a * c;

        if (a == 0)
        {
            Console.WriteLine("Not a Quadratic equation");
        }
        else if (eq > 0)
        {
            Console.WriteLine("Roots are Real and Distinct");
            root1 = (-b + Math.Sqrt(eq)) / (2 * a);
            root2 = (-b - Math.Sqrt(eq)) / (2 * a);
            
            Console.WriteLine("First Root Root1: {0:#.##}", root1);
            Console.WriteLine("Second Root Root2: {0:#.##}", root2);
        }
        else if (eq == 0)
        {
            Console.WriteLine("\t\tRoots are Real and Equal");
            root1 = root2 = (-b) / (2 * a);

            Console.WriteLine("\t\tFirst Root Root1: {0:#.##}", root1);
            Console.WriteLine("\t\tSecond Root Root2: {0:#.##}\n\n", root2);
        }
        else
        {
            Console.WriteLine("Roots are Imaginary");
            root1 = (-b) / (2 * a);
            root2 = Math.Sqrt(-eq) / (2 * a);

            Console.WriteLine("First Root1: {0:#.##} + i{1:#.##}" ,root1, root2);
            Console.WriteLine("Second Root2: {0:#.##} - i{1:#.##}" ,root1, root2);
        }
    }

    public static void Main()
    {
        double a=0;
        double b=0;
        double c=0;
        
        Console.WriteLine("\n\n");

        Console.Write("\t\tEnter the value of a: ");
        a = double.Parse(Console.ReadLine());

        Console.Write("\t\tEnter the value of b: ");
        b = double.Parse(Console.ReadLine());

        Console.Write("\t\tEnter the value of c: ");
        c = double.Parse(Console.ReadLine());

        ComputeRoot(a, b, c);
    }
}
