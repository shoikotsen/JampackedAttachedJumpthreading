using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number to check if it is a perfect number:");
        int userInput = int.Parse(Console.ReadLine());
        if (IsPerfectNumber(userInput))
        {
            Console.WriteLine($"Perfect Number");
        }
        else
        {
            Console.WriteLine($"Not a Perfect Number");
        }
    }

    static bool IsPerfectNumber(int number)
    {
        int sum = 0;
        for (int i = 1; i < number; i++)
        {
            if (number % i == 0)
            {
                sum += i;
            }
        }
        return sum == number;
    }
}
// 2024/6/12_SenShoikot_Exercise 4.1