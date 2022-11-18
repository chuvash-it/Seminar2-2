// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.Write("Введите трехзначное число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// if (1000 > num1 && num1 > 99)
// {
//     int num2 = (num1 / 10) % 10;
//     Console.WriteLine($"Вторая цифра числа: {num2}");
// }
// else
// {
//     Console.WriteLine($"Число {num1} не является трехзначным");
// }

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num > 99)
// {
//     while (num> 999)
//     {
//         num = num / 10;
//     }
// int result = num % 10;
// Console.WriteLine(result);
// }
// else
// Console.Write("Третьей цифры нет ");

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите цифру обозначающую день недели: ");
int day = Convert.ToInt32(Console.ReadLine());
if (day > 0 && day < 8)
{
Console.WriteLine(Square(day) ? "выходной" : "рабочий");

bool Square (int day)
{
    return day < 8 && day > 5;}
}
else
{
    Console.WriteLine($"Дня недели под цифрой {day} нет");
}