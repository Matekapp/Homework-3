
class Program
{
    static void Main()
    {
        // 1) Count vowels
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();
        int vowelCount = 0;
        foreach (char c in input.ToLower())
        {
            if ("aeiou".Contains(c))
            {
                vowelCount++;
            }
        }
        Console.WriteLine($"Number of vowels: {vowelCount}");

        // 2) Multiplication table
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        int[] multiplicationTable = new int[10];

        Console.WriteLine($"Multiplication Table of {number}:");
        for (int i = 1; i <= 10; i++)
        {
            multiplicationTable[i - 1] = number * i;
            Console.WriteLine($"{number} x {i} = {multiplicationTable[i - 1]}");
        }

        // 3) Matrix addition
        int[,] matrixA = new int[3, 3];
        int[,] matrixB = new int[3, 3];
        int[,] resultMatrix = new int[3, 3];

        Console.WriteLine("Enter values for Matrix A:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"A[{i},{j}]: ");
                matrixA[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("Enter values for Matrix B:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"B[{i},{j}]: ");
                matrixB[i, j] = int.Parse(Console.ReadLine());
            }
        }

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                resultMatrix[i, j] = matrixA[i, j] + matrixB[i, j];
            }
        }

        Console.WriteLine("Result Matrix:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(resultMatrix[i, j] + " ");
            }
            Console.WriteLine();
        }

        // 4) Calculator
        while (true)
        {
            Console.WriteLine("Calculator Menu:");
            Console.WriteLine("1) Addition");
            Console.WriteLine("2) Subtraction");
            Console.WriteLine("3) Multiplication");
            Console.WriteLine("4) Division");
            Console.WriteLine("5) Exit");
            Console.Write("Choose an option: ");
            int option = int.Parse(Console.ReadLine());

            if (option == 5)
                break;

            Console.Write("Enter first number: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            double num2 = double.Parse(Console.ReadLine());
            double result = 0;

            switch (option)
            {
                case 1:
                    result = num1 + num2;
                    break;
                case 2:
                    result = num1 - num2;
                    break;
                case 3:
                    result = num1 * num2;
                    break;
                case 4:
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("Cannot divide by zero.");
                        continue;
                    }
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    continue;
            }
            Console.WriteLine($"Result: {result}");
        }
    }
}