using System;
public class Practical_assigment_22
 {
   static void Main(string[] args)
  {
   /*● Establish how many elements are smaller than average value.*/
   int[] numbers = {10, 4, -4, 7, 0, 9, 1, 3, 7, -5};
   int sum = 0;
   foreach ( int number in numbers )
   {
     sum += number;
   } 
     double average = (double) sum / numbers.Length;
     int smallCount = 0;
     foreach ( int number in numbers )
       {
       if  ( number <  average)  
        {
             smallCount++;  
        }   
      }
      Console.Write($"There are {smallCount} numbers smaller than average value.\n");
  }
 }
   
   



     


 