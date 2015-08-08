using System;

class Problem03
{
    static void Main()
    {
        string text = Console.ReadLine();

        int index = text.IndexOf("in");

        int counter = 0;

        while (index>-1)
        {
            counter++;
            index = text.IndexOf("in",index+2);
        }

        Console.WriteLine(counter);
    }
}

