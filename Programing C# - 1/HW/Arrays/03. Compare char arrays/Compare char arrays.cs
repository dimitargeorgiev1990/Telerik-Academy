using System;

// Write a program that compares two char arrays lexicographically (letter by letter).

class CompareCharArrays
{
    static void Main()
    {
        char[] arr = new char[] { 'A', 'A', 'A' };
        char[] arr1 = new char[] { 'A', 'A' , 'a'};
        string str = new string(arr);
        string str1 = new string(arr1);



        if (str.CompareTo(str1) == -1)
        {
            Console.WriteLine("First array is before than the second.");
        }
        else if (str.CompareTo(str1) == 0)
        {
            Console.WriteLine("Arrays are the same.");
        }
        else
        {
            Console.WriteLine("First array is after than the second.");
        }
    }
}
