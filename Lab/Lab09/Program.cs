using System.Collections.Generic;

namespace CollectionsApplication{
    class Program{
        static void Main(string[] args){
            Stack<string> st = new Stack<string>();
            st.Push("Hello");
            st.Push("Hi");
            Console.WriteLine("\n\n");
            foreach (string C in st){
                Console.WriteLine("\t\t" + C);
            }
            Console.WriteLine();
            st.Pop();
            foreach (string C in st){
                Console.WriteLine("\t\t" + C);
            }
            Console.WriteLine("\n\n");
        } 
    }
}