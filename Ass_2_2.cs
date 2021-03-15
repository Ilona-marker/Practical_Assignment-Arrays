using System;
public class Practical_ass
 {
   static void Main(string[] args)
  { 
 /*● Print out elements are odd.
 ● Compute how many elements are odd (uneven). */
      int[] numbers = {10, 4, -4, 7, 0, 9, 1, 3, 7, -5};
      Console.Write("Odd(uneven) numbers: ");
      int oddCount = 0;
      foreach (int number in numbers)
       {
        if (number  % 2 != 0 ) 
        {
           Console.Write(number + " ");
           oddCount++;  
        }   
      }
        Console.WriteLine();
        Console.WriteLine($"There are {oddCount} odd(uneven) numbers");
   }
 }         
   