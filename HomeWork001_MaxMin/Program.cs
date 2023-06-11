Console.Clear();
// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее.

//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

int a = 5;
int b = 15;

int max = a;

if (a > max) max = a;
if (b > max) max = b;
    Console.Write("a = 5, b = 7 -> max = ");
    Console.WriteLine(max);


// else
// {
//     Console.Write("");
// }

// if(username.ToLower() == "irina")
// {
//     Console.WriteLine("YEEE, It's Irina!!!");
// }

// else
// {
//     Console.Write("Hello, ");
//     Console.Write(username);
//     Console.Write("!");
// }