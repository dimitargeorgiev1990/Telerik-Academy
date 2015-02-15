using System;

// Write a program that sorts an array of integers using the Merge sort algorithm.

class MergeSortt
{
    static void Main(string[] args)
    {
        int[] array = { 111123, 5, 22, 3, 2, 66, 111 };
        MergeSortSearching(array, 0, 6);

        foreach (int number in array)
        {
            Console.Write(number + " ");
        }
    }
    public static void MergeSortSearching(int[] input, int left, int right)
    {
        if (left < right)
        {
            int middle = (left + right) / 2;

            MergeSortSearching(input, left, middle);
            MergeSortSearching(input, middle + 1, right);

            //Merge
            int[] leftArray = new int[middle - left + 1];
            int[] rightArray = new int[right - middle];

            Array.Copy(input, left, leftArray, 0, middle - left + 1);
            Array.Copy(input, middle + 1, rightArray, 0, right - middle);

            int i = 0;
            int j = 0;
            for (int k = left; k < right + 1; k++)
            {
                if (i == leftArray.Length)
                {
                    input[k] = rightArray[j];
                    j++;
                }
                else if (j == rightArray.Length)
                {
                    input[k] = leftArray[i];
                    i++;
                }
                else if (leftArray[i] <= rightArray[j])
                {
                    input[k] = leftArray[i];
                    i++;
                }
                else
                {
                    input[k] = rightArray[j];
                    j++;
                }
            }
        }
    }
}
