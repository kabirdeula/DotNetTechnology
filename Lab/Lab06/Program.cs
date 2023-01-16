// Program to check whether a number is divisible by 7 but not 13.

using System;

namespace ConsoleApp{
    class Example{
        public static void Main(){
            Console.Write("\n\n\t\tEnter a number: ");
            int x = int.Parse(Console.ReadLine());
            if(x % 7 == 0 && x % 13 != 0){
                Console.WriteLine("\t\t{0} is divisible by 7 but not 13.\n\n", x);
            }else{
                Console.WriteLine("\t\tCondition not matched.\n\n");
            }
        }
    }
}