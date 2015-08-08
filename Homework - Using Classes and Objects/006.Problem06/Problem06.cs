using System;
using System.Linq;

class Problem06
{
    static void Main()
    {
        int[] numbers = new int[] { 1, 2, 3, 4, 5 };
        string input = Console.ReadLine();
        decimal sum = SumNumbers(input);
        Console.WriteLine(sum);
    }
    static decimal SumNumbers(string inputNums)
    {
        string[] inputAsStrArr = inputNums.Split();
        int[] numbers = new int[inputAsStrArr.Length];
        numbers = Array.ConvertAll<string, int>(inputAsStrArr, int.Parse);


        decimal sum = numbers.Sum();
        return sum;
    }
}

