// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// произведение матриц
int[,] MultIntMatrix(int[,] a, int[,] b)
{
    if (a.GetLength(0) != b.GetLength(1))
        Console.WriteLine("Произведение не возможно.");
    int[,] result = new int[a.GetLength(0), b.GetLength(1)];
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < b.GetLength(1); j++)
        {
            result[i, j] = 0;
            for (int k = 0; k < a.GetLength(1); k++)
            {
                result[i, j] += a[i, k] * b[k, j];
            }
        }
    }
    return result;
}


// вывод массива в консоль
void PrintArray2d(int[,] array)
{
    for (int k = 0; k < array.GetLength(0); k++)
    {
        for (int i = 0; i < array.GetLength(1); i++)
        {
            Console.Write($"{array[k, i]} ");
        }
        Console.WriteLine();
    }
}

int[,] matrixA = new int[,] { { 2, 4 }, { 3, 2 } };
int[,] matrixB = new int[,] { { 3, 4 }, { 3, 3 } };
Console.WriteLine("Дана матрица А:");
PrintArray2d(matrixA);
Console.WriteLine("Дана матрица В:");
PrintArray2d(matrixB);
Console.WriteLine("A * B = ");
PrintArray2d(MultIntMatrix(matrixA, matrixB));