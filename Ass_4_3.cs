using System;

namespace SGT_DotNet5_Examples
{
    class Ass_4_3
    {
        static void Main(string[] args)
        /*The built-in method Array.Sort(), as its name suggests, sorts an array. 
        This method is a quick way to further organize array data into a logical sequence*/
        {
          int[] numbers = { 10, 4, -4, 7, 0, 9, 1, 3, 7, -5 };
          Array.Sort(numbers);
          for ( int i = 0; i < numbers.Length; i++ )
         {
           Console.Write(numbers[i] + " ");  
         }
           Console.WriteLine();
        }
    }
}        