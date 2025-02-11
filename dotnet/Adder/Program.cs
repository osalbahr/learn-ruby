﻿// Parse the first number
Console.Write("Enter the 1st number: ");
var line = Console.ReadLine();
if (String.IsNullOrEmpty(line))
{
    Console.Write("Line is empty. Please try again.");
    Environment.Exit(1);
}
var firstNumber = Int32.Parse(line);

// Parse the second number
Console.Write("Enter the 2nd number: ");
line = Console.ReadLine();
if (String.IsNullOrEmpty(line))
{
    Console.Write("Line is empty. Please try again.");
    Environment.Exit(1);
}
var secondNumber = Int32.Parse(line);

// Output the sum of the two numbers
Console.WriteLine("Sum: " + (firstNumber + secondNumber));
