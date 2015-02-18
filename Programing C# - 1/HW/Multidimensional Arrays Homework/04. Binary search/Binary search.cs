using System;

// Write a program, that reads from the console an array of N integers and an integer K, sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K.

class BinarySearch
{
    static void Main()
    {
        Console.Write("Array with elements N=");
        int n = int.Parse(Console.ReadLine());
        Console.Write("K=");
        int k = int.Parse(Console.ReadLine());
        int count = 0;
        int[] array = new int[n];
        
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("element[{0}]=", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(array);
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] <= k)
            {
                count = i + 1;
            }
        }
        Array.BinarySearch(array, count);
        if (k < array[0])
        {
            Console.WriteLine("K={0} is smoller then min element in array ", k);
        }
        else
        {
            Console.WriteLine("In array {0} are smoller or equal then K={1} ", count, k);
        }

    }
}
