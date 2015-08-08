using System;

class Problem05
{
    static void Main()
    {
        string text = "We are living in a <upcase> yellow submarine </upcase>. We don't have <upcase> anything </upcase> else.";

        //string[] textSplit = text.Split();

        int startIndex = text.IndexOf("<upcase>");
        int endIndex = text.IndexOf("</upcase>");

        string resultText = text;

        while (startIndex > -1 && endIndex > -1)
        {
            string textToReplace = text.Substring(startIndex-1, endIndex - startIndex+10);
            string capitalLettersText = text.Substring(startIndex + 8, endIndex - startIndex - 9).ToUpper();

            resultText = resultText.Replace(textToReplace, capitalLettersText);

            startIndex = text.IndexOf("<upcase>", endIndex + 9);
            endIndex = text.IndexOf("</upcase>", endIndex + 9);
        }
        Console.WriteLine(resultText);
    }
}

