using System;

class C{
    abstract class A{
    public abstract void display();
}

class B:A{
    public override void display(){
        Console.WriteLine("\t\tI am a boy");        
    }
}

    public static void Main(string[] args){
        B d = new B();
        Console.WriteLine("\n\n");
        d.display();
        d.display();
        Console.WriteLine("\n\n");
    }
}