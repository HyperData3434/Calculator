﻿using System;

namespace Calc
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;

            Console.WriteLine("Console calculator\r");
            Console.WriteLine("------------------\n");
            
            Console.WriteLine("Choose an option");
            Console.WriteLine("\t+ - Add");
            Console.WriteLine("\t- - Subtract");
            Console.WriteLine("\t* - Multiply");
            Console.WriteLine("\t/ - Divide");
            Console.WriteLine("Type your option then pres Enter");
            var Operation = Console.ReadLine();
            
            Console.WriteLine("Type your first number, and then press Enter");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Type another number, and then press Enter");
            num2 = Convert.ToInt32(Console.ReadLine());
            
            switch (Operation)
            {
                case "+":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine();
                    Console.WriteLine("The answer is:");
                    Console.WriteLine($"{num1} + {num2} = " + (num1 + num2));
                    Console.ResetColor();
                    break;
                case "-":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine();
                    Console.WriteLine("The answer is:");
                    Console.WriteLine($"{num1} - {num2} = " + (num1 - num2));
                    Console.ResetColor();
                    break;
                case "*":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine();
                    Console.WriteLine("The answer is:");
                    Console.WriteLine($"{num1} * {num2} = " + (num1 * num2));
                    Console.ResetColor();
                    break;
                case "/":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine();
                    Console.WriteLine("The answer is:");
                    Console.WriteLine($"{num1} / {num2} = " + (num1 / num2));
                    Console.ResetColor();
                    break;
            }
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Press return/enter to close the Calculator console app.");
            Console.ResetColor();
            while (Console.ReadKey().Key != ConsoleKey.Enter) {}
        }
    }
}