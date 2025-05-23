using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();               // 1/1
        Fraction f2 = new Fraction(5);              // 5/1
        Fraction f3 = new Fraction(3, 4);           // 3/4
        Fraction f4 = new Fraction(1, 3);           // 1/3

        DisplayFraction(f1);  // Should output: 1/1  => 1
        DisplayFraction(f2);  // Should output: 5/1  => 5
        DisplayFraction(f3);  // Should output: 3/4  => 0.75
        DisplayFraction(f4);  // Should output: 1/3  => 0.333...

        // Testing getters and setters
        f1.SetTop(2);
        f1.SetBottom(5);
        Console.WriteLine("Updated f1:");
        DisplayFraction(f1);  // Should output: 2/5 => 0.4
    }

    static void DisplayFraction(Fraction f)
    {
        Console.WriteLine(f.GetFractionString());
        Console.WriteLine(f.GetDecimalValue());
    }
}