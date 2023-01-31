//Задача 25: Напишите функцию, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//Нельзя использовать библиотеку Math!
//3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите число A: ");
int numA = Convert.ToInt32(Console.ReadLine()!);
Console.Write("Введите число B: ");
int numB = Convert.ToInt32(Console.ReadLine()!);

int Exponentiation(int numberA, int numberB)
{
  int result = 1;
  for(int i=1; i <= numberB; i++)
  {
    result = result * numberA;
  }
    // int result = Math.Pow(numberA, numberB);
    return result;
}

int exponentiation = Exponentiation(numA, numB);
Console.WriteLine("Ответ: " + exponentiation);