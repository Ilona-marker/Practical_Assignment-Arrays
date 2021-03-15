using System;
public class Practical_assignments_1_4
 {
   static void Main(string[] args)
  {
      /*Write a program where array elements will be printed out: 
      ● Create an array with six int elements: 5, 3, 7, 6, 2, 8; 
      ● Print out each element using do...while loop; */
      int[] number = { 5, 3, 7, 6, 2, 8 };
      int k = 0;
      do 
      {
          Console.Write(number[k] + " ");
          k++;
      }
      while ( k < number.Length);
      Console.WriteLine();
  }
 }  