class Shape {
    protected int width, height;

    public void setWidth(int w) {
        width = w;
    }

    public void setHeight(int h) {
        height = h;
    }
}

class Rectangle : Shape {
    public int getArea() {
        return (width * height);
    }
}

class Triangle : Shape {
    public int getArea() {
        return (width * height) / 2;
    }
}

class TestInheritance {
    static void Main(string[] args) {
        Rectangle rect = new Rectangle();
        Triangle tri = new Triangle();

        rect.setWidth(5);
        rect.setHeight(7);
        tri.setWidth(5);
        tri.setHeight(7);
        Console.WriteLine("\n\n");
        Console.WriteLine("\t\tTotal area of rectangle: {0}", rect.getArea());
        Console.WriteLine("\t\tTotal area of triangle: {0}", tri.getArea());
        Console.WriteLine("\n\n");
        Console.ReadKey();
    }
}
