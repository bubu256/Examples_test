// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

void SortArray(int[,] array)
{
    int temp, max, index_max;
    for (int k = 0; k < array.GetLength(0); k++)
    {
        for (int i = 0; i < array.GetLength(1) - 1; i++)
        {
            max = array[k,i];
            index_max = i;
            for (int j = i + 1; j < array.GetLength(1); j++)
            {
                if (array[k,j] > max)
                {
                    index_max = j;
                    max = array[k,j];        
                }
            }
            if (index_max != i)
            {
                temp = array[k,i];
                array[k,i] = array[k,index_max];
                array[k,index_max] = temp;
            }
        }
    }
}

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

int[,] matrix = new int[,] {{1, 5, 4, 3},
                            {2, 4, 7, 3},
                            {8, 1, 2, 6},
                            {9, 1, 4, 7}
                            };

Console.WriteLine("Задан массив:");
PrintArray2d(matrix);
SortArray(matrix);
Console.WriteLine("Строки отсортированы по убыванию:");
PrintArray2d(matrix);