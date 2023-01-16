using System;  
public class Array{  
    public static void Main(string[] args){
        int n,i,j=0,lrg,lrg2nd;
  	    int[] arr1 = new int[50];

        Console.Write("\n\n\t\tFind the second largest element in an array :\n");
  
        Console.Write("\t\tInput the size of array : ");
	    n = Convert.ToInt32(Console.ReadLine()); 	   
        /* Stored values into the array*/
        Console.Write("\n\t\tInput {0} elements in the array :\n",n);
        for(i=0;i<n;i++){
	        Console.Write("\t\telement - {0} : ",i);
	    	arr1[i] = Convert.ToInt32(Console.ReadLine()); 		  
	    }
    
        /* find location of the largest element in the array */		
        lrg=0;

        for(i=0;i<n;i++){
            if(lrg<arr1[i]){
                lrg=arr1[i];
                j = i;
            }
        }
    
        /* ignore the largest element and find the 2nd largest element in the array */		
        lrg2nd=0;
        for(i=0;i<n;i++){
            if(i==j){
                i++;  /* ignoring the largest element */
                i--;
            }else{
                if(lrg2nd<arr1[i]){
                    lrg2nd=arr1[i];
                }
            }
        }
    
        Console.WriteLine("\n\t\tThe Second largest element in the array is :  {0} \n\n", lrg2nd);
    }
}
