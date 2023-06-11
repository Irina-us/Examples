// Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

Console.Clear();
Console.WriteLine("Определяем день недели");

System.Console.WriteLine("Введите номер дня недели от 1 до 7");
int num = Convert.ToInt32( Console.ReadLine() );
if (num == 7)
{
    num = 0;
}
    Console.WriteLine((DayOfWeek)num);
