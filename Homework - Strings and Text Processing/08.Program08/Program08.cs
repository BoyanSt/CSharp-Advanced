using System;

class Program08
{
    static void Main()
    {
        string inputText = Console.ReadLine();
        string searchedWord = " in ";

        string textResult = null;
        int positionDot = 0;
        int positionSearchedWord = 0;

        positionDot = inputText.IndexOf('.');
        int counter = 0;

        while (positionDot > -1)
        {
            string sentence = inputText.Substring(0 + counter, positionDot + 1 - counter);
            positionSearchedWord = sentence.IndexOf(searchedWord);

            if (positionSearchedWord > -1)
            {
                textResult = textResult + sentence;
            }

            counter = positionDot + 1;
            positionDot = inputText.IndexOf('.', positionDot + 1);
        }
        Console.WriteLine(textResult);
    }
}
