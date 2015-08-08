using System;

class Problem01
{
    static void Main()
    {
        int inputYear = int.Parse(Console.ReadLine());
        bool isLeap = DateTime.IsLeapYear(inputYear);

        if (isLeap)
        {
            Console.WriteLine("{0} is a leap year.",inputYear);
        }
        else
        {
            Console.WriteLine("{0} is not a leap year.",inputYear);
        }
    }
}

