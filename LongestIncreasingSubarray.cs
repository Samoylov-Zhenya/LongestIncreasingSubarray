using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine();
        var numbers = input.Split(' ').Select(x => double.Parse(x)).ToArray();
        
        //int[] numbers = {    1,2,3,    1,2,3,4,5,6,  7 ,1, 2, 3, 4, 5, 6 };
        int counter = 0;
        int counterMax = 0;
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > numbers[i - 1])
            {
                counter++;
            }
            else
            {
                if (counter > counterMax)
                {
                    counterMax = counter;    
                }
                counter = 0;
            }
        }
        if (counter > counterMax)
        {
            counterMax = counter;
        }
        Console.Write(counterMax + 1);
    }
}