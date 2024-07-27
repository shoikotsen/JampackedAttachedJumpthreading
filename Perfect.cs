using System;

public class Program
{
    static void Main(string[] args)
    {
        // Prompt the user to enter a number to check if it's a perfect number
        Console.WriteLine("Enter a number to check if it is a perfect number:");
        // Read the user input and convert it to an integer
        int userInput = int.Parse(Console.ReadLine());
        // Check if the entered number is a perfect number
        if (IsPerfectNumber(userInput))
        {
            // If the number is perfect, print "Perfect Number"
            Console.WriteLine($"Perfect Number");
        }
        else
        {
            // If the number is not perfect, print "Not a Perfect Number"
            Console.WriteLine($"Not a Perfect Number");
        }
    }
    // Function to check if a number is a perfect number
    static bool IsPerfectNumber(int number)
    {
        int sum = 0;// Initialize the sum of divisors to 0
        // Loop through all numbers less than the given number
        for (int i = 1; i < number; i++)
        {
            // Check if 'i' is a divisor of 'number'
            if (number % i == 0)
            {
                // If it is, add 'i' to the sum
                sum += i;
            }
        }
         // A number is perfect if the sum of its divisors equals the number itself
        return sum == number;
    }
}
// 2024/6/12_SenShoikot_Exercise 4.1