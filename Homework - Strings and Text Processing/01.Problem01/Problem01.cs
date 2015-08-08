using System;

class Problem01
{
    static void Main()
    {
        string inputText = Console.ReadLine();

        char[] textAsCharArr = inputText.ToCharArray();
        Array.Reverse(textAsCharArr);
        Console.WriteLine(textAsCharArr);
    }
}

