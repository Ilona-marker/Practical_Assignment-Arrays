using System;
public class Practical_assignments
 {
   static void Main(string[] args)
  {
      /*Write a program where array elements will be printed out: 
      ● Create an array with six int elements: 5, 3, 7, 6, 2, 8; 
      ● Print out each element using while loop; */
      int[] number = { 5, 3, 7, 6, 2, 8 };
      int i = 0;
      while ( i < number.Length) 
       {
         Console.Write(number[i] + " "); 
         i++;
       }
         Console.WriteLine();
      }
    } 
  