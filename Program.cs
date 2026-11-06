using System;

public class Program
{
    public static void Main(string[] args)
    {
        bool running = true;

        while (running)
        {
            // Display the main menu (Home)
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("===== Calculator =====");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Subtract");
            Console.WriteLine("3. Multiply");
            Console.WriteLine("4. Divide");
            Console.WriteLine("0. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                // Add or Summation
                case "1":
                    bool adding = true;

                    while (adding)
                    {
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine("===== Add =====");

                        // Get two numbers from the user
                        Console.Write("Enter first number: ");
                        double num1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter second number: ");
                        double num2 = Convert.ToDouble(Console.ReadLine());

                        // Show the result
                        double sum = num1 + num2;
                        Console.WriteLine("Result: " + sum);

                        // Ask what to do next (repeat until the input is valid)
                        string next;
                        while (true)
                        {
                            Console.WriteLine();
                            Console.WriteLine("1. Add again");
                            Console.WriteLine("2. Back to Home");
                            Console.Write("Choose an option: ");
                            next = Console.ReadLine();

                            if (next == "1" || next == "2")
                            {
                                break; // Valid input, stop asking
                            }

                            Console.WriteLine("Invalid choice! Please enter 1 or 2.");
                        }

                        if (next == "2")
                        {
                            adding = false; // Leave the Add section, return to Home
                        }
                    }
                    break;

                // Exit the program
                case "0":
                    Console.WriteLine("Goodbye!");
                    running = false;
                    break;
            }
        }
    }
}