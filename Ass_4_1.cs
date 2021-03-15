using System;

namespace SGT_DotNet5_Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program where elements sorting will be performed.
            //Please take a look to the most popular sorting algorithm Merge sort
            int[] array = { 10, 4, -4, 7, 0, 9, 1, 3, 7, -5 };
            // { { 10, 4, -4, 7, 0 }, { 9, 1, 3, 7, -5 } }
            // { { { 10, 4, -4 }, { 7, 0 } }, { { 9, 1, 3 }, { 7, -5 } } }
            // { { { { 10, 4 }, { -4 } }, { { 7 }, { 0 } } }, { { { 9, 1 }, { 3 } }, { { 7 }, { -5 } } } }
            // { { { { { 10 }, { 4 } }, { -4 } }, { { 7 }, { 0 } } }, { { { { 9 }, { 1 } }, { 3 } }, { { 7 }, { -5 } } } }
            // { { { {      4, 10    }, { -4 } }, {     0, 7     } }, { { {     1, 9     }, { 3 } }, {    -5, 7      } } }
            // { { {       -4, 4, 10           }, {     0, 7     } }, { {       1, 3, 9           }, {    -5, 7      } } }
            // { {         -4, 0, 4, 7, 10                         }, {         -5, 1, 3, 7, 9                         } }
            // { -5, -4, 0, 1, 3, 4, 7, 7, 9, 10 }

            foreach (int element in array) Console.Write(element + " ");
            Console.WriteLine();

            // Mergesort
            array = Sort(array);

            foreach (int element in array) Console.Write(element + " ");
            Console.WriteLine();
        }

        static int[] Sort(int[] unsorted, string prefix = "")
        {
            if (unsorted.Length <= 1)
            {
                return unsorted;
            }

            // 10 total elements => left=5, right=5
            //  5 total elements => left=2+1, right=2
            int[] left = new int[unsorted.Length / 2 + unsorted.Length % 2];
            int[] right = new int[unsorted.Length / 2];
            for (int i = 0; i < unsorted.Length; i++)
            {
                if (i < left.Length)
                {
                    left[i] = unsorted[i];
                }
                else
                {
                    right[i - left.Length] = unsorted[i];
                }
            }

            Console.Write(prefix + "Left: ");
            foreach (int element in left) Console.Write(element + " ");
            Console.Write("Right: ");
            foreach (int element in right) Console.Write(element + " ");
            Console.WriteLine();

            left = Sort(left, prefix + "  ");
            right = Sort(right, prefix + "  ");

            int[] sorted = new int[unsorted.Length];
            int leftIndex = 0, rightIndex = 0;
            Console.Write(prefix + "Merging result: ");
            for (int i = 0; i < sorted.Length; i++)
            {
                if (rightIndex >= right.Length)
                {
                    // reached end of right array:
                    sorted[i] = left[leftIndex++];
                }
                else if (leftIndex >= left.Length)
                {
                    // reached end of left array:
                    sorted[i] = right[rightIndex++];
                }
                else if (left[leftIndex] < right[rightIndex])
                {
                    // left array element is smaller:
                    sorted[i] = left[leftIndex++];
                }
                else
                {
                    // right array element is smaller (or equal):
                    sorted[i] = right[rightIndex++];
                }
                Console.Write(sorted[i] + " ");
            }
            Console.WriteLine();

            return sorted;
        }
    }
}
