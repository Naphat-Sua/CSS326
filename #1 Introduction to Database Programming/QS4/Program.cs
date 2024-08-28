using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the number of students: ");
        int numberOfStudents = Convert.ToInt32(Console.ReadLine());

        int[] scores = new int[numberOfStudents];

        for (int i = 0; i < numberOfStudents; i++)
        {
            Console.Write($"Enter the score for student {i + 1}: ");
            scores[i] = Convert.ToInt32(Console.ReadLine());
        }

        double classAverage = CalculateClassAverage(scores);

        Console.WriteLine($"The class average is: {classAverage:F2}");
    }

    static double CalculateClassAverage(int[] scores)
    {
        int sum = 0;
        for (int i = 0; i < scores.Length; i++)
        {
            sum += scores[i];
        }

        return (double)sum / scores.Length;
    }
}
