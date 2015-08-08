using System;

class Problem06
{
    static void Main()
    {
        string text = Console.ReadLine();

        int textLenght = text.Length;
        string textResult = null;

        if (textLenght<20)
        {
            string addText = new string('*', 20 - textLenght);
            textResult = text + addText;
        }

        Console.WriteLine(textResult);
    }
}

