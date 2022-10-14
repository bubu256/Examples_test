// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


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

double[] AverageForColumnMatrix(int[,] matrix)
{
    double[] result = new double[matrix.GetLength(1)];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        int sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[i, j];
        }

        result[j] = sum / matrix.GetLength(0);
    }
    return result;
}


Console.WriteLine("Задан массив:");
int[,] matrix = new int[,]{
                            {1,2,3,4,5},
                            {6,7,8,9,10},
                            {5,7,5,9,8},
                        };
PrintArray2dInt(matrix);

double[] meanArray = AverageForColumnMatrix(matrix);

Console.WriteLine("Средние арифметические по столбцам:");
for (int i = 0; i < meanArray.Length; i++)
{
    Console.Write($"{Math.Round(meanArray[i], 2)}  ");
}