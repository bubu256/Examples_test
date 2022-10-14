// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

// функция заполняет массив случайными вещественными числами
void FillArray2dDoubleRandom(double[,] array2dDouble, double min, double max)
{
    System.Random rnd = new System.Random();
    for (int i = 0; i < array2dDouble.GetLength(0); i++)
    {
        for (int j = 0; j < array2dDouble.GetLength(1); j++)
        {
            array2dDouble[i, j] = rnd.NextDouble() * (max - min) + min;
        }
    }
}

// функция вывода матрицу c округлением элементов до 2 знаков после запятой
void PrintArray2d(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{Math.Round(matrix[i,j], 2)}  ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите через Enter размерность матрицы m и n:");
int m = Int32.Parse(Console.ReadLine());
int n = Int32.Parse(Console.ReadLine());
double[,] matrix = new double[m,n];
FillArray2dDoubleRandom(matrix, -10, 10);
PrintArray2d(matrix);
