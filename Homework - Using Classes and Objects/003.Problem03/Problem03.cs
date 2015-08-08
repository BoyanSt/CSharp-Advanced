using System;

class Problem03
{
    static void Main()
    {
        DateTime timeNow = DateTime.Now;
        var dayOfWeek = timeNow.DayOfWeek;
        Console.WriteLine("Today is {0}.",dayOfWeek);
        DateTime timeTomorrow = timeNow.AddDays(1);
        Console.WriteLine("Tomorrow is {0}", timeTomorrow.DayOfWeek);
    }
}

