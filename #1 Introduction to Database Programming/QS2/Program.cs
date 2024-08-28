using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a positive integer: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int sum = 0;
        int i = 1;

        while (i <= number)
        {
            sum += i;
            i++;
        }

        Console.WriteLine($"The sum of numbers from 1 to {number} is: {sum}");
    }
}
