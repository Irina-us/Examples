Console.Clear();
// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее.

//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

System.Console.WriteLine("Введите целое число1");
int num1 = Convert.ToInt32( Console.ReadLine() );

System.Console.WriteLine("Введите целое число2");
int num2 = Convert.ToInt32( Console.ReadLine() );

// int max = num1;

// if (num1 > max) max = num1;
// if (num2 > max) max = num2;

//     Console.Write("max = ");
//     Console.WriteLine(max);

// int min = num2;

// if (num1 < min) min = num1;
// if (num2 < min) min = num2;

//     Console.Write("min = ");
//     Console.WriteLine(min);

if (num1 > num2) 
{
    Console.WriteLine("max = "+num1);
    Console.WriteLine("min = "+num2);
}
else 
    if(num1 < num2)
{
    Console.WriteLine("min = "+num1);
    Console.WriteLine("max = "+num2);
}
else 
{
    Console.WriteLine("min = max = "+num1);
}

// WTF??