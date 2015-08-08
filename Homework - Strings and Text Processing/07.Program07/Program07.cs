using System;

class Program07
{
    static void Main()
    {
        string text = Console.ReadLine();
        string key = Console.ReadLine();

        string result = null;

        for (int i = 0, counterKey = 0; i < text.Length; i++,counterKey++)
        {
            if (counterKey == key.Length)
            {
                counterKey = 0;
            }
            result = result + Convert.ToString(text[i] ^ key[counterKey]);
        }
        Console.WriteLine(result);
    }
}

