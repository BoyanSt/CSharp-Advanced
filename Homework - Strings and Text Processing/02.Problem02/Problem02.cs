using System;

class Problem02
{
    static void Main()
    {
        string inputText = Console.ReadLine();

        int counterBrakets = 0;
        bool isCorrectBrakets = false;

        for (int i = 0; i < inputText.Length; i++)
        {
            if (inputText[i] == '(')
            {
                counterBrakets++;
            }


            if (inputText[i] == ')')
            {
                counterBrakets--;
            }

            if (counterBrakets<0)
            {
                isCorrectBrakets = true;
                break;
            }
        }

        if (isCorrectBrakets)
        {
            Console.WriteLine("Incorrect brakets");
        }
        else
        {
            Console.WriteLine("Correct brakets.");
        }
    }
}

