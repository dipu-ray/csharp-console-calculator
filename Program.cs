using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Display the menu
        Console.WriteLine("===== Calculator =====");
        Console.WriteLine("1. Add");
        Console.WriteLine("2. Subtract");
        Console.WriteLine("3. Multiply");
        Console.WriteLine("4. Divide");
        Console.WriteLine("0. Exit");
        Console.Write("Choose an option: ");
        string choice = Console.ReadLine();

        // Get two numbers from the user
        Console.Write("Enter first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        // Perform the selected operation
        switch (choice)
        {
            // Add or Summation
            case "1":
                double sum = num1 + num2;
                Console.WriteLine("Result: " + sum);
                break;
        }
    }
}