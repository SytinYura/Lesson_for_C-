/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа
456 -> 5
782 -> 8
918 -> 1
*/

Console.WriteLine("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine()!);
int num = number / 10 % 10;
Console.WriteLine($"{number} –> {num}");


// ---------------------------------
/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. (Цифры считать справа налево).
645 -> 6
78 -> третьей цифры нет
32679 -> 6 */

Console.WriteLine("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine()!);
int num = number / 100;
if (num == 0) Console.WriteLine($"В числе {number} третьей цифры нет");
else Console.WriteLine($"{number} –> {num % 10}");

// ---------------------------------

/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет */

Console.Write("Введите цифру, обозначающий день недели: от 1 до 7: ");
int daynum = int.Parse(Console.ReadLine()!);
if (daynum < 1 || daynum > 7) Console.WriteLine("Введите цифру от 1 до 7:");
else if (daynum == 6 || daynum == 7) Console.WriteLine($"{daynum} –> Да");
else Console.WriteLine($"{daynum} -> Нет");