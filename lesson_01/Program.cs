// Коммент в одну строчку
/* для большихк омментариев котороые нужно закрыть */
//  Ctrl + /  это горячая клавиша



// ---------- Задача 1 на уроке ----------


Console.Write("Введи число: ");
int number = int.Parse(Console.ReadLine()!); //конвертируем с помощью int.Perse в числа / ! - ставим для того, чтобы считаволось число null

// Решение математическое
int num = number * number;
Console.WriteLine(num); // выводим сразу значение num
Console.WriteLine($"Квадрат числа {number} равен {num}"); //$ - знак интерполяции прозволянет внутри текста вызывать пременные {переменная}

// Решение через библиотеку
int num2 = Convert.ToInt32(Math.Pow(number, 2)); //Math.Pow это библиотека / Convert.ToInt32 конвертируем все остальное (кроме чисел)
*/



// ---------- Задача 2 - Принимает и сравнивает два числа ----------


Console.Write("Введи первое число: ");
int number1 = int.Parse(Console.ReadLine()!); //конвертируем с помощью int.Perse в числа / ! - ставим для того, чтобы считаволось число null
int a = number1;

Console.Write("Введи второе число: ");
int number2 = int.Parse(Console.ReadLine()!);
int b = number2;
if(a > b)
    Console.WriteLine($"{number1} больше");
else
    Console.WriteLine($"{number2} больше");



// ---------- Задача 4 - Принимает три числа и сравнивает и выводит наибольший ----------



Console.Write("Введи первое число: ");
int number1 = int.Parse(Console.ReadLine()!);

Console.Write("Введи второе число: ");
int number2 = int.Parse(Console.ReadLine()!);

Console.Write("Введи третье число: ");
int number3 = int.Parse(Console.ReadLine()!);

    int result = number1;
    if (number2 > result) result = number2;
    if (number3 > result) result = number3;
    Console.WriteLine($"{result} больше");
    return result; // Работает :) 



// ---------- Задача 6 - Определить четное или нечетное число ----------


Console.Write("Введи число: ");
int number = int.Parse(Console.ReadLine()!);
    if ((number % 2) == 0)
        {
            Console.WriteLine($" {number} четное число");
        }
    else
        {
            Console.WriteLine($" {number} нечетное число");
        }



// ---------- Задача 8 - Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N ----------



Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine()); //ToInt32 выводит текст через запятую
int num = 2;

if(number > 1)
{
    while(num <= number) // <= оператор
    {
        Console.Write(num + " ");
        num = num + 2;
    }
}





