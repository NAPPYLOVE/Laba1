﻿namespace calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double total;
            char oper;

            Console.WriteLine("Введите первое число:");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите оператор:");
            oper = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            b = Convert.ToDouble(Console.ReadLine());

            if (oper == '+')
            {
                total = a + b;
                Console.WriteLine("Cумма " + a + " и " + b + " равна " + total + ".");
            }

            else if (oper == '-')
            {
                total = a - b;
                Console.WriteLine("Разность " + a + " и " + b + " равна " + total + ".");
            }

            else if (oper == '*')
            {
                total = a * b;
                Console.WriteLine("Умножение " + a + " на " + b + " равно " + total + ".");
            }

            else if (oper == '/')
            {
                if (b != 0)
                {
                    total = a / b;
                    Console.WriteLine("Деление " + a + " на " + b + " равно " + total);
                }
                else
                {
                    Console.WriteLine("Деление на 0 невозможно!");
                }
        }
    }
}