using System;

// Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
    // Use the Selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.

class SelectionSort
{
    static void Main()
    {
        // Read

        Console.Write("Enter arr size: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];

        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("arr[" + i + "] = ");
            arr[i] = int.Parse(Console.ReadLine());
        }

        // Selection Sort 

        int min = int.MaxValue;
        int minElementIndex = -1;
        int indexToGo = -1;

        for (int i = 0; i < arr.Length; i++)
        {
            // find min element and his index
            for (int j = i; j < arr.Length; j++)
            {
                if (arr[j] < min)
                {
                    min = arr[j];
                    minElementIndex = j;
                }
            }

            indexToGo++; // started from - 1 -> 0

            int temp = arr[indexToGo];
            arr[indexToGo] = min;
            arr[minElementIndex] = temp;
            min = int.MaxValue;
        }

        // print
        Console.WriteLine(string.Join(", ", arr));
    }
}
