// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3
Console.Write("Введите M (количество чисел для ввода): ");
int m = Int32.Parse(Console.ReadLine());
int count_positive_numbers = 0;

for (int i = 0; i < m; i++)
{
    Console.Write($"Введите число {i+1}: ");
    if (Int32.Parse(Console.ReadLine()) > 0) count_positive_numbers++;
}

Console.Write($"Введено чисел больше нуля: {count_positive_numbers}");
