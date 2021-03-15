using System;
public class Practical_assigm
 {
   static void Main(string[] args)
  {
 /*Write a program where multiple actions with an array will be done. 
 For element filtering please use the loop (the loop type can be chosen as you want). 
 ● Create an array with ten int elements: 10, 4, -4, 7, 0, 9, 1, 3, 7, -5; 
 ● Compute average value of the array.*/
   int[] number = {10, 4, -4, 7, 0, 9, 1, 3, 7, -5};
   int sum = 0;
   for ( int i = 0; i < number.Length; i++ )
   {
     sum += number[i];
   } 
     double average = (double) sum / number.Length;
     Console.WriteLine($"Average value is : {average.ToString("0.##")}");
  }
 }