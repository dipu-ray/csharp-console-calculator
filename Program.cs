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
                        Console.WriteLine("===== Add =====");
                        Console.Write("Enter first number: ");
                        double num1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter second number: ");
                        double num2 = Convert.ToDouble(Console.ReadLine());
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
                                break;
                            }

                            Console.WriteLine("Invalid choice! Please enter 1 or 2.");
                        }

                        if (next == "2")
                        {
                            adding = false;
                        }
                    }
                    break;

                // Subtract
                case "2":
                    bool subtracting = true;

                    while (subtracting)
                    {
                        Console.Clear();
                        Console.WriteLine("===== Subtract =====");
                        Console.Write("Enter first number: ");
                        double subNum1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter second number: ");
                        double subNum2 = Convert.ToDouble(Console.ReadLine());
                        double difference = subNum1 - subNum2;
                        Console.WriteLine("Result: " + difference);

                        // Ask what to do next (repeat until the input is valid)
                        string subNext;
                        while (true)
                        {
                            Console.WriteLine();
                            Console.WriteLine("1. Subtract again");
                            Console.WriteLine("2. Back to Home");
                            Console.Write("Choose an option: ");
                            subNext = Console.ReadLine();

                            if (subNext == "1" || subNext == "2")
                            {
                                break;
                            }

                            Console.WriteLine("Invalid choice! Please enter 1 or 2.");
                        }

                        if (subNext == "2")
                        {
                            subtracting = false;
                        }
                    }
                    break;

                // Multiply
                case "3":
                    bool multiplying = true;

                    while (multiplying)
                    {
                        Console.Clear();
                        Console.WriteLine("===== Multiply =====");
                        Console.Write("Enter first number: ");
                        double mulNum1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter second number: ");
                        double mulNum2 = Convert.ToDouble(Console.ReadLine());
                        double product = mulNum1 * mulNum2;
                        Console.WriteLine("Result: " + product);

                        // Ask what to do next (repeat until the input is valid)
                        string mulNext;
                        while (true)
                        {
                            Console.WriteLine();
                            Console.WriteLine("1. Multiply again");
                            Console.WriteLine("2. Back to Home");
                            Console.Write("Choose an option: ");
                            mulNext = Console.ReadLine();

                            if (mulNext == "1" || mulNext == "2")
                            {
                                break;
                            }

                            Console.WriteLine("Invalid choice! Please enter 1 or 2.");
                        }

                        if (mulNext == "2")
                        {
                            multiplying = false;
                        }
                    }
                    break;

                // Exit the program (with confirmation)
                case "0":
                    string confirm;
                    while (true)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Are you sure you want to exit?");
                        Console.WriteLine("1. Yes, exit");
                        Console.WriteLine("2. No, back to Home");
                        Console.Write("Choose an option: ");
                        confirm = Console.ReadLine();

                        if (confirm == "1" || confirm == "2")
                        {
                            break;
                        }

                        Console.WriteLine("Invalid choice! Please enter 1 or 2.");
                    }

                    if (confirm == "1")
                    {
                        Console.WriteLine();
                        Console.WriteLine("Thanks for using Console Calculator and see you next time!");
                        running = false;
                    }
                    break;
            }
        }
    }
}