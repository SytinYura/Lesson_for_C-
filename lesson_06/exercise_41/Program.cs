// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write("Введите числа через пробел: "); //Split создает массив подстрок, разбивая входную строку по одному или нескольким разделителям.
int[] Array = System.Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int count = 0;
for (int i = 0; i < Array.Length; i++)
{
    if (Array[i] > 0)
    {
        count++;
    }
}
Console.WriteLine($"Кол-во элементов > 0: {count}");
