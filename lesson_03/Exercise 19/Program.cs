// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите число: ");
string? num = Console.ReadLine(); //вводим и считываем /string - строка

void CheckingNumber(string number) //метод void
{ 
  if (number[0]==number[4] || number[1]==number[3]) // или или
  {
    Console.WriteLine($"Число: {number} - палиндром.");
  }
  else Console.WriteLine($"Число: {number} - не палиндром.");
}

if (num!.Length == 5)
{
  CheckingNumber(num);
}

else Console.WriteLine($"Введи число из задачи");