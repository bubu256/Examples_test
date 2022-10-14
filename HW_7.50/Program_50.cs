// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

// функция вывода матрицы int
void PrintArray2dInt(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}  ");
        }
        Console.WriteLine();
    }
}
Console.WriteLine("Задана массив:");
int[,] matrix = new int[,]{
                            {1,2,3,4,5},
                            {6,7,8,9,10},
                            {5,7,5,9,8},
                        };

PrintArray2dInt(matrix);
Console.WriteLine("Введите индексы массива i j (через Enter):");
int indexi = Int32.Parse(Console.ReadLine());
int indexj = Int32.Parse(Console.ReadLine());
if (0 <= indexi && indexi < matrix.GetLength(0) 
    && 0 <= indexj && indexj < matrix.GetLength(1))
    Console.WriteLine($"Элемент: {matrix[indexi, indexj]}");
else Console.WriteLine("Такого элемента не существует.");