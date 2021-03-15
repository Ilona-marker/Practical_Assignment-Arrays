using System;
public class Practical_assigment
 {
   static void Main(string[] args)
  {
 /*Write a program where multiple actions with an array will be done. 
 For element filtering please use the loop (the loop type can be chosen as you want). 
 ● Create an array with ten int elements: 10, 4, -4, 7, 0, 9, 1, 3, 7, -5; 
 ● Print out elements which are negative.*/
      int[] numbers = {10, 4, -4, 7, 0, 9, 1, 3, 7, -5};
      Console.WriteLine("Elements which are negative: "); 
      foreach (int number in numbers)
      {
        if (number < 0 )  
        {
        Console.Write(number + " ");
        }  
      }
        Console.WriteLine(); 
      }
   }  
            
