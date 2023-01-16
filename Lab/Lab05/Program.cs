// Develop a C# console application to implement threading concepts.
using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        // Create a new thread
        Thread thread = new Thread(PrintNumbers);

        // Start the thread
        thread.Start();

        // Print numbers on the main thread
        PrintNumbers();
    }

    static void PrintNumbers()
    {
        Console.WriteLine("\n\n\t");
        for (int i = 1; i <= 10; i++)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine("\n\n");
    }
}
