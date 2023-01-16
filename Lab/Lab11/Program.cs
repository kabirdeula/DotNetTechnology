using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace matrixMultiplication{
    class Program{
        static void Main(string[] args){
            int i,j,m,n;

            Console.Write("\n\n\t\tEnter the number of Rows and Columns: ");	   
            m = Convert.ToInt32(Console.ReadLine());
            n = Convert.ToInt32(Console.ReadLine());

            int[,] a = new int[m, n];

            Console.Write("\t\tInput elements in the first matrix :\n");
            for(i = 0; i < m; i++){
                for(j = 0; j < n; j++){
			        a[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.Write("\n\t\tFirst matrix is :\n");
  		    for(i = 0; i < m; i++){
      		    for(j = 0; j < n; j++){
          	        Console.Write(a[i,j] + "\t");
    		    }
                Console.WriteLine();
            }

            int[,] b = new int[m, n];

            Console.Write("\t\tInput elements in the second matrix :\n");
            for(i = 0; i < m; i++){
                for(j = 0; j < n; j++){
			        b[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.Write("\n\t\tSecond matrix is :\n");
  		    for(i = 0; i < m; i++){
      		    for(j = 0; j < n; j++){
          	        Console.Write(b[i,j] + "\t");
    		    }
                Console.WriteLine();
            }

            Console.WriteLine("\t\tMatrix Multiplication is: ");
            int[,] c = new int[m, n];
            for (i = 0; i < m; i++){
                for (j = 0; j < n; j++){
                    c[i, j] = 0;
                    for (int k = 0; k < 2; k++){
                        c[i, j] += a[i, k] * b[k, j];
                    }
                }
            }

            for (i = 0; i < m; i++){
                for (j = 0; j < n; j++){
                    Console.Write(c[i, j] + "\t");
                }
                Console.WriteLine();
            }            
        }
    }
}