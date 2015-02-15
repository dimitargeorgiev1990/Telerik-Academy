using System;

// Write a program that finds the maximal sequence of equal elements in an array.

class MaximalSequence
{
    static void Main()
    {
        Console.Write("Enter arr size: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];

        int maxSequenceEqualElCount = 0, tempSequenceEqualElCount = 0;
        int startIndex = 0, endIndex = 0;

        int currentElement = arr[0];

        // Read element by element and Calculate sequence
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("arr[" + i + "] = ");
            arr[i] = int.Parse(Console.ReadLine());

            if (currentElement == arr[i])
                tempSequenceEqualElCount++;
            else
            {
                if (tempSequenceEqualElCount >= maxSequenceEqualElCount)
                {
                    maxSequenceEqualElCount = tempSequenceEqualElCount;
                    endIndex = i - 1;
                    startIndex = endIndex - (maxSequenceEqualElCount - 1);
                }
                currentElement = arr[i];
                tempSequenceEqualElCount = 1;
            }
        }

        if (tempSequenceEqualElCount >= maxSequenceEqualElCount)
        {
            maxSequenceEqualElCount = tempSequenceEqualElCount;
            endIndex = arr.Length - 1;
            startIndex = endIndex - (maxSequenceEqualElCount - 1);
        }

        // print results
        Console.WriteLine("Max sequence of equal elements is: " + maxSequenceEqualElCount);
        int[] longestSequence = new int[maxSequenceEqualElCount];
        Array.Copy(arr, startIndex, longestSequence, 0, maxSequenceEqualElCount);
        Console.WriteLine(string.Join(", ", longestSequence));
    }
}
