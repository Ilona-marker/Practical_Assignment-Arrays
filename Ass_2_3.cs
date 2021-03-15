
 using System;

 public class Programm
 {
   static void Main(string[] args)
   {
      /*● Verify if there are multiple elements with the same value */
      int[] number = {10, 4, -4, 7, 0, 9, 1, 3, 7, -5};
      for (int i = 0; i < number.Length; i++ )
      {
         for (int j = i + 1; j < number.Length; j++ ) 
         {
            if (number[i] == number[j]) 
            {
             Console.WriteLine($"Found {number[i]} at indexes {i} and {j}.");
            }      
         }
       }    
    }
 }
  



 