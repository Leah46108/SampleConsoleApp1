// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

public class Program
{
    //NO 1 Problem
    public static void Problem1()
    {
        Console.WriteLine("Please enter File path:");
        string file = Console.ReadLine();

        using (FileStream filestream = File.Open(file, FileMode.Open))
        {
            Console.WriteLine($"File '(file)' successfully open!");
        }
    }

    //No 2 Problem
    public static void Problem2()
    {
        int num;
        Console.Write("Input Number:");
        num = Convert.ToInt32(Console.ReadLine());

        try
        {
            if (num >= 0 || num <= 1000)
            {
                Console.WriteLine("Valid number");
            }
        }
        catch (Exception e)
        {
            throw new Exception("Invalid number");
        }

    }

    //No 3 Problem
    public static void Problem3()
    {
        int[] numbers = { 1, 2, 3, 4, 5 };

        double ave = CalcuAverage(numbers);

        Console.WriteLine($" Average value: {ave}");
    }

    static double CalcuAverage(int[] array)
    {
        int sum = 0;
        foreach(int num in array)
        {
            sum += num;
        }
        return (double)sum / array.Length;

    }

    //No 4 Problem
    public static void Problem4()
    {
        string input = String.Empty;
        try
        {
            int result = Int32.Parse(input);
            Console.WriteLine(result);
        }
        catch (FormatException)
        {
            Console.WriteLine($"Unable to parse '{input}'");
        }

    }

    //No 5 problem
    public static void Problem5()
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter the list of integers:");

        while (true)
        {
            Console.Write("Please enter a number: ");
            string userinput = Console.ReadLine();

            if (int.TryParse(userinput, out int number)) 
            {
                numbers.Add(number);
            }
            else
            {
                break; 
            }

            Console.WriteLine("List of integers:");
            foreach(int num in numbers)
            {
                Console.WriteLine(num);
            }
        }
    }

    //No 6 problem
    public static void Problem6()
    {
        Console.Write("Please enter first number:");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Please enter second number:");
        int num2 = int.Parse(Console.ReadLine());

        double result = num1/num2;
        Console.WriteLine($"Result is: {result}");

    }

    //No 9 problem
    public static void Problem9()
    {
        string str;

        Console.WriteLine("Please input string:");

    }

    
}