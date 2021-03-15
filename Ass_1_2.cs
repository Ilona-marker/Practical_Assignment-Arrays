using System;
public class Practical
 {
   static void Main(string[] args)
  {
      /*Write a program where array elements will be printed out: 
      ● Create an array with six int elements: 5, 3, 7, 6, 2, 8; 
      ● Print out each element using for each loop*/
      int[] numbers = { 5, 3, 7, 6, 2, 8 };
      
      foreach (int number in numbers)
      {
       Console.Write(number + " ");   
      }
      Console.WriteLine();
    } 
  }