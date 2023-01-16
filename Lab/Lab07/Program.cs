using System;

public class PalindromeExample{

    public static void Main(String[] args){ 
        
        int n, r, sum = 0, temp;

        Console.Write("\n\n\t\tEnter number more than one digit: ");
        n = int.Parse(Console.ReadLine());
        
        temp = n;

        while(n>0){
            r = n % 10;
            sum = (sum *10) + r;
            n = n / 10;
        }
        if(temp == sum) Console.WriteLine("\t\t{0} is palindrome number.\n\n", temp); 
        else Console.WriteLine("\t\t{0} isn't pallindrome.\n\n", temp);
    }
}