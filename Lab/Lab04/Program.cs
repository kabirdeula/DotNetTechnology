class Number {
    public int num;

    public Number(int n) {
        num = n;
    }

    public static Number operator +(Number a, Number b) {
        return new Number(a.num + b.num);
    }

    public static Number operator -(Number a, Number b) {
        return new Number(a.num - b.num);
    }

    public static Number operator *(Number a, Number b) {
        return new Number(a.num * b.num);
    }

    public static Number operator /(Number a, Number b) {
        return new Number(a.num / b.num);
    }

    public void display() {
        Console.WriteLine("\n\t\tThe number is: " + num);
    }
}

class Program {
    static void Main(string[] args) {
        Number a = new Number(10);
        Number b = new Number(20);
        Number c = new Number(0);

        c = a + b;
        c.display();

        c = a - b;
        c.display();

        c = a * b;
        c.display();

        c = a / b;
        c.display();
        Console.WriteLine("\n\n");
        Console.ReadKey();
    }
}
