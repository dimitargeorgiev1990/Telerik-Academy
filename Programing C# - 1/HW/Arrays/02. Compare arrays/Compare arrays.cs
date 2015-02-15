using System;

// Write a program that reads two integer arrays from the console and compares them element by element.

class CompareArrays
{
    static void Main()
    {
        Console.WriteLine("Please enter arrays size:");
        int n = int.Parse(Console.ReadLine());

        int[] arr1 = new int[n];
        int[] arr2 = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter " + i + " element's value from the first arr");
            arr1[i] = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter " + i + " element's value from the second arr");
            arr2[i] = int.Parse(Console.ReadLine());

            if (arr1[i] > arr2[i])
            {
                Console.WriteLine("Element [" + i +"] from first array is bigger than element [" + i + "] from second array.");
            }
            else if (arr1[i] < arr2[i])
            {
                Console.WriteLine("Element [" + i + "] from first array is smaller than element [" + i + "] from second array.");
            }
            else
            {
                Console.WriteLine("Element [" + i + "] from first array is equal to element [" + i + "] from second array.");
            }
        }
    }
}
