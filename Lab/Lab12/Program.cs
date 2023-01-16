using System;

namespace ConsoleApp{
    class Program{
        public static void Main(string[] args){
            int[] a = {1, 2, 3, 4, 5};
            int i;
            try{
                for (i = 0; i < a.Length;){
                    Console.WriteLine("\n\n\t\t" + a[0]);
                    break;
                } 
            }catch (SystemException){
                Console.WriteLine("\t\tArray index out of bound.");
            }finally{
                Console.WriteLine("\t\tFinal Statement\n\n");
            }
        }
    }
}