﻿// Напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное
// на само себя).

// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

Console.WriteLine("Введите целое число");
int num = Convert.ToInt32( Console.ReadLine() );
int result = num*num;
System.Console.WriteLine("Квадрат введенного числа равен "+result);