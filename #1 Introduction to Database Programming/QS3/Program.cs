using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the number of elements in the array: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[n];

        Console.WriteLine($"Enter {n} integer elements:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Element {i + 1}: ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        int sum = 0;
        int max = arr[0];
        int min = arr[0];

        for (int i = 0; i < n; i++)
        {
            sum += arr[i];
            if (arr[i] > max)
            {
                max = arr[i];
            }
            if (arr[i] < min)
            {
                min = arr[i];
            }
        }

        double average = (double)sum / n;

        Console.WriteLine($"Sum of elements: {sum}");
        Console.WriteLine($"Maximum element: {max}");
        Console.WriteLine($"Minimum element: {min}");
        Console.WriteLine($"Average of elements: {average}");
    }
}
