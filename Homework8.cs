namespace Homework8;
using System;

public class HelloWorld
{
    // function to calculate sum of array elements
    public static void ArraySum(int[] int_array){
        int sum = 0;
        // iterating till end of array to sum up all the elements
        foreach (int item in int_array) {
            sum += item;
        }
 // printing the sum to console
        Console.WriteLine(sum);
    }
    // main function to test the function
    public static void Main(string[] args)
    {
        int[] array = { 11, 23, 31, 42, 53 };
        ArraySum(array);
        
    }
}

using System;

class Program
{
    static void Main()
    {

        // Question-1
        int[,] array2D = new int[3,3] {{1,2,3}, {4,5,6}, {7, 8, 9}};
        printAllOddNumber(array2D);
            

        // Question-2
        int sum = ElementSum(array2D);  
        Console.WriteLine("\nQ2. The Sum of array elements: " + sum); 
            

        // Question-3
        int[ , ] res = DoubleArray(array2D);
        Console.WriteLine("\nQ3. The new 2d Array: "); 
        int n =  res.GetLength(0);
        int m =  res.GetLength(0);
        for(int i = 0; i < n; i++) {
            for(int j = 0; j < m; j++) {
              Console.Write(res[i,j]+ " ");
            }
        }
        
    }
    
    public static void printAllOddNumber(int[,] array_2d) {
        
        // get row and column.
        int n =  array_2d.GetLength(0);
        int m =  array_2d.GetLength(0);
        
        Console.WriteLine("\nQ1. Print all odd numbers: "); 
        
        for(int i = 0; i < n; i++) {
            for(int j = 0; j < m; j++) {
                // If odd found.
                if(array_2d[i,j] % 2 == 1) {
                  Console.Write(array_2d[i, j] + " ");  
                }
            }
        }
    }
    
    public static int ElementSum(int[,] array_2d) {
        
        int n =  array_2d.GetLength(0);
        int m =  array_2d.GetLength(0);
            
        // keep track of sum.
        int sum = 0;
        
        for(int i = 0; i < n; i++) {
            for(int j = 0; j < m; j++) {
              sum += array_2d[i, j];  
            }
        }
        
        return sum;
    }
    
    public static int[,] DoubleArray(int[,] array_2d) {
        
        int n =  array_2d.GetLength(0);
        int m =  array_2d.GetLength(0);
        
        // declare new array with same size.
        int[,] res = new int[n, m];
        
        for(int i = 0; i < n; i++) {
            for(int j = 0; j < m; j++) {
              res[i,j] = 2 * array_2d[i, j];  
            }
        }
            
        // return res.
        return res;
    }
    
    
}