using System;
public class Practical_assignments_Arrays
 {
   static void Main(string[] args)
  {
      /*Write a program where array elements will be printed out: 
      ● Create an array with six int elements: 5, 3, 7, 6, 2, 8; 
      ● Print out each element using for loop;*/
      int[] numbers = { 5, 3, 7, 6, 2, 8 };
      for (int i = 0; i < numbers.Length; i++)
      {
        Console.Write(numbers[i] + " ");  
      }
      Console.WriteLine();
    } 
  }

      