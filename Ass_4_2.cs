using System;

namespace SGT_DotNet5_Examples
{
    class Ass_4_2
    {
        static void Main(string[] args)
         //Write a program where elements sorting will be performed.
         //Please take a look to the most popular sorting algorithm Bubble sort
        {
          int[] array = { 10, 4, -4, 7, 0, 9, 1, 3, 7, -5 };

            foreach (int element in array) Console.Write(element + " ");
            Console.WriteLine();

            // Bubble sort
            bool repeat = true, startAtZero = true;
            int low = 0, high = array.Length - 2;
            while (repeat)
            {
                repeat = false;

                for (int i = startAtZero ? low : high;
                    startAtZero ? (i <= high) : (i >= low);
                    i += (startAtZero ? 1 : -1))
                {
                    if (array[i] > array[i + 1])
                    {
                        repeat = true;

                        int num = array[i + 1]; // = 4;
                        array[i + 1] = array[i];
                        array[i] = num;
                    }
                }

                if (repeat)
                {
                    if (startAtZero)
                    {
                        high--;
                    }
                    else
                    {
                        low++;
                    }

                    startAtZero = !startAtZero;
                }

                foreach (int element in array) Console.Write(element + " ");
                Console.WriteLine();
            }
        }
    }      
}                 