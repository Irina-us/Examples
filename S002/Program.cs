﻿// Задача №1. Напишите программу, которая на вход принимает два числа и проверяет,
// является ли первое число квадратом второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет

Console.Clear();
Console.WriteLine("Проверяем, является ли первое число квадратом второго");

System.Console.WriteLine("Введите целое число 1");
int num1 = Convert.ToInt32( Console.ReadLine() );

System.Console.WriteLine("Введите целое число 2");
int num2 = Convert.ToInt32( Console.ReadLine() );

if (num2*num2 == num1)
    Console.WriteLine("Да, "+num1+" является квадратом "+num2);
else 
    Console.WriteLine("Нет, "+num1+" не является квадратом "+num2);