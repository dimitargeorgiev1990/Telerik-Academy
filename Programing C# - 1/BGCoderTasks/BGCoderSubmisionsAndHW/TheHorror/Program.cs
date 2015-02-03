using System;
class Horror
{
    static void Main()
    {
        string input = Console.ReadLine();
        int sum = 0;
        int counter = 0;
        for (int i = 0; i < input.Length; i++)
        {
            if (char.IsDigit(input[i]) && i % 2 == 0)
            { 
                sum += int.Parse(input[i].ToString());
                counter++;
            }
        }
        Console.WriteLine(counter + " " + sum);
        //if (input[0] == '-')
        //{
        //    for (int i = 1; i < input.Length; i++)
        //    {
        //        if ((i - 1) % 2 == 0)
        //        {
        //            sum += (int)input[i] - (int)'0';
        //            counter++;
        //        }
        //    }

        //}
        //else
        //{
        //    for (int i=0; i < input.Length; i++)
        //    {
        //        if (i % 2 == 0)
        //        {
        //            sum += (int)input[i] - (int)'0';
        //            counter++;
        //        }
        //    }
        //}

        
    }
}

