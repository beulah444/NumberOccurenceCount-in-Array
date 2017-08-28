using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        int[] sortedarray = new int[] { 1, 2, 3, 5, 5,5, 12, 90, 120, 169, 671 };
        Console.WriteLine("enter number");
        bool isNum = int.TryParse(Console.ReadLine(), out int result);
        if (isNum)
        {
            int count = 0;
            foreach (int i in sortedarray)
            {
                if(i==result)
                {
                    count++;
                }

            }
            if (count == 1)
            { Console.WriteLine("The number {0} has occurred {1}  times in the array", result, count); }
            else
            { Console.WriteLine("The number {0} is not present in the array", result); }
            
        }
        else
        {
            Console.WriteLine("Invalid number");
        }
        Console.ReadKey();
    }
}