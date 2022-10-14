// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Clear();

// Сумма элементов строки двумерного массива. Реализация с рекурсией.
int SumOfRowIntArray2d(int[,] array2d, int index_row, int index_start_element = 0)
{
    if (index_start_element == array2d.GetLength(1) - 1)
        return array2d[index_row, index_start_element];
    return array2d[index_row, index_start_element] + SumOfRowIntArray2d(array2d, index_row, index_start_element + 1);
}

// вывод массива в консоль
void PrintArray2d(int[,] array)
{
    for (int k = 0; k < array.GetLength(0); k++)
    {
        for (int i = 0; i < array.GetLength(1); i++)
        {
            Console.Write($"{array[k,i]} ");
        }
        Console.WriteLine();
    }
}

int[,] array2d = new int[,] { { 10, 2, 4 }, { 4, 5, 6 }, { 7, 8, 4 } };
PrintArray2d(array2d);

// поиск строки с минимальной суммой
int minimumSum = SumOfRowIntArray2d(array2d, 0);
int minimumTemp = 0;
int minimumIndexRow = 0;
for (int i=1; i<array2d.GetLength(0); i++)
{
    minimumTemp = SumOfRowIntArray2d(array2d, i);
    if (minimumTemp < minimumSum) 
    {
        minimumSum = minimumTemp;
        minimumIndexRow = i;
    }
}
Console.WriteLine($"Минимальная сумма строки в строке {minimumIndexRow + 1}.");