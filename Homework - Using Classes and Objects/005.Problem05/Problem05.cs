using System;

class Problem05
{
    static void Main()
    {
        DateTime startDate = DateTime.Now;
        Console.WriteLine("Please enter the date.");
        DateTime endDate = DateTime.Parse(Console.ReadLine());

        int counterWorkDays = 0;

        while (startDate.Date!=endDate.Date)
        {
            
            if (startDate.DayOfWeek.ToString() !="Saturday"&&startDate.DayOfWeek.ToString()!="Sunday")
            {
                counterWorkDays++;
            }
            startDate = startDate.AddDays(1);
        }
        Console.WriteLine(counterWorkDays);
    }
}

