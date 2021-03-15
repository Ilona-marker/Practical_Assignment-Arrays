using System;
public class Practical_assigment_3
 {
   static void Main(string[] args)
   {
   //Create a byte array with length 10. The grades will be stored in the array. 
     byte[] grades = new byte [10];
     int failedCount = 0, perfectCount = 0;
     for ( int i = 0; i < grades.Length; i++) 
       {
           Console.Write($"Enter the grade #{i + 1}: ");
           // Do verification of the number range of each input value. Input values need to be in range 0 to +10
           // array will be: 2, 5, 10, 3, 10, 7, 8, 5, 10, 6
            while (!Byte.TryParse(Console.ReadLine(), out grades[i]) || grades[i] > 10 )
         {
           Console.Write($"Incorrect value! Enter the grade #{i + 1}: ");
         }
          //● Do calculations how many students failed (the grade is smaller than 4). 
          //● Do calculations how many students got an “A” (the grade is 10).
            if ( grades[i] < 4 ) 
            {
              failedCount++;
            }
            else if ( grades[i] == 10 ) 
            {
              perfectCount++;
            }
          }
          Console.WriteLine($"{failedCount} students failed (grade < 4).");
          Console.WriteLine($"{perfectCount} students had an 'A'( grade is 10 )");
          //Create a histogram of number frequencies in the grade array
          int[] histogram = new int [11];
          foreach ( byte grade in grades ) 
          {
            histogram[grade]++;
          }
          for ( int grade = 0; grade < histogram.Length; grade++ )
          {
            int count = histogram[grade];
            Console.WriteLine($"{count} students with the grade {grade}");
          }
    }
 }
     
   

















   