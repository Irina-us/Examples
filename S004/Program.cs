// Задача 5 Напишите программу, которая на вход принимает одно число (N),
// а на выходе показывает числа в промжутке от -N до N
// 2 -> "-2,-1, 0, 1, 2"

Console.Clear();
Console.WriteLine("Показывает числа в промежутке от -N до N");

System.Console.WriteLine("Введите любое число");
int N = Convert.ToInt32( Console.ReadLine() );
int start = -N;
while (start != N)
{
    Console.Write(start + " ");
    start += 1;
}
