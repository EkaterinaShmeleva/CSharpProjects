using System;

class Calculator
{
    static void Main()
    {
        Console.WriteLine("Willkommen beim Taschenrechner!");
        Console.Write("Erste Zahl: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Operator (+, -, *, /): ");
        string op = Console.ReadLine();

        Console.Write("Zweite Zahl: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double result = op switch
        {
            "+" => num1 + num2,
            "-" => num1 - num2,
            "*" => num1 * num2,
            "/" when num2 != 0 => num1 / num2,
            _ => double.NaN
        };

        Console.WriteLine($"Ergebnis: {result}");
    }
}
