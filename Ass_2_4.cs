using System;
public class Practical_assigmen
 {
   static void Main(string[] args)
  {
 /*Write a program where multiple actions with an array will be done. 
 For element filtering please use the loop (the loop type can be chosen as you want). 
 ● Create an array with ten int elements: 10, 4, -4, 7, 0, 9, 1, 3, 7, -5; 
 ● Print out each second element.*/
   int[] number = {10, 4, -4, 7, 0, 9, 1, 3, 7, -5};
   Console.Write("Every second element: ");
   for (int i = 0; i < number.Length; i += 2 )
   {
       Console.Write(number[i] + " ");   
   }
   Console.WriteLine();       
  }
 }