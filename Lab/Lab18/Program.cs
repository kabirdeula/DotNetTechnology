class Program
{
    public delegate int PerformCalculation(int x, int y);

    static void Main(string[] args)
    {
        PerformCalculation add = new PerformCalculation(Add);
        PerformCalculation multiply = new PerformCalculation(Multiply);

        Console.WriteLine("\n\n\t\t" + add(6, 9));
        Console.WriteLine("\t\t" + multiply(6, 9) + "\n\n");
    }

    public static int Add(int x, int y)
    {
        return x + y;
    }

    public static int Multiply(int x, int y)
    {
        return x * y;
    }
}