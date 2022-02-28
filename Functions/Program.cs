﻿using System;

namespace Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Esimene arv:");
            int userNumberOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Teine number:"  );
            int userNumberTwo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Tehe? '+', '-', '*', '/'" );
            char userOperator = Convert.ToChar(Console.ReadLine());

            switch (userOperator)
            {
                case '+':
                    AddTwoNumbers(userNumberOne, userNumberTwo);
                    break;
                case '/':
                    DivideTwoNumbers(userNumberOne, userNumberTwo);
                    break;
                case '-':
                    MinusTwoNumbers(userNumberOne, userNumberTwo);
                    break;
                case '*':
                    MultiplyTwoNumbers(userNumberOne, userNumberTwo);
                    break;
                default:
                    Console.WriteLine("proovi uuesti");
                    break;
            }
        }

        public static void AddTwoNumbers(int x, int y)
        {
            int result = x + y;
            Console.WriteLine(result);
        }

        public static void DivideTwoNumbers(double x, double y)
        {
            double result = x / y;
            Console.WriteLine(result);
        }
        public static void MinusTwoNumbers(int x, int y)
        {
            int result = x - y;
            Console.WriteLine(result);
        }
        public static void MultiplyTwoNumbers(int x, int y)
        {
            int result = x * y;
            Console.WriteLine(result);
        }
    }
}
