using System;
using System.Collections.Generic;

namespace ConsoleApp{
    class Program{
        static void Main(string[] args){
            LinkedList<string> q = new LinkedList<string>();
            
            q.AddLast("Deula");
            q.AddLast("Kabir");

            Console.WriteLine("\n\n");
            foreach (string b in q){
                Console.WriteLine("\t\t" + b);
            }
            Console.WriteLine("\n\n");
        }
    }
}