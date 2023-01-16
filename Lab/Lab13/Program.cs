using System;

namespace ConsoleApp{
    class Program{
        public virtual void display(){
            Console.WriteLine("\n\n\t\tHey\n\n");
        }
    }

    class Project:Program{
        public override void display(){
            Console.WriteLine("\n\n\t\tI\n\n");
        }
    }

    class Projects{
        public static void Main(string[] args){
            Project a = new Project();
            a.display();
        }
    }
}