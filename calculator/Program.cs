﻿using System;
static int ReadInt(string prompt)
{
    while (true)
    {
        Console.Write(prompt);
        var s = Console.ReadLine();
        if (int.TryParse(s, out var v)) return v;
        Console.WriteLine("This is not a valid int.");
    }
}
static int Add(int a, int b) => a + b;
static int Subtract(int a, int b) => a - b;
static int Multiply(int a, int b) => a * b;
static double? Divide(int a, int b)
{
    if (b == 0) return null;
    return (double)a / b;
}

while (true)
{
    Console.WriteLine("Welcome to simple calculator.");
    Console.Write("Please enter an operator ('+', '-', '*', '/' or 'q': ");
    var op = Console.ReadLine()?.Trim();
    if (string.IsNullOrEmpty(op)) continue;
    if (op.Equals("q", StringComparison.OrdinalIgnoreCase)) break;

    if (op is "+" or "-" or "/" or "*")
    {
        var a = ReadInt("Enter a: ");
        var b = ReadInt("Enter b: ");
        
        switch (op)
        {
            case "+":
                Console.WriteLine(Add(a, b));
                break;
            case "-":
                Console.WriteLine(Subtract(a, b));
                break;
            case "*":
                Console.WriteLine(Multiply(a, b));
                break;
            case "/":
                Console.WriteLine(Divide(a, b));
                break;
        }
    }
    else
    {
        Console.WriteLine("Enter a valid operation.");
    }
}

Console.WriteLine("Goodbye, thank you for using the calculator.");