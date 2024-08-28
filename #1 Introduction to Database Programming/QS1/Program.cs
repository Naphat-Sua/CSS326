using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        int N1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the second number: ");
        int N2 = Convert.ToInt32(Console.ReadLine());

        int Sum = N1 + N2;
        int Difference = N1 - N2;
        int Product = N1 * N2;
        double Quotient = (double)N1 / N2;

        Console.WriteLine("Sum: " + Sum);
        Console.WriteLine("Difference: " + Difference);
        Console.WriteLine("Product: " + Product);
        Console.WriteLine("Quotient: " + Quotient);
    }
}
