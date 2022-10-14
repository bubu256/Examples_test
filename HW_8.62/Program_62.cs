// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

// заполняет массив по спирали
void FillSpiralArray2d(int[,] array, int i = 0, int j = 0, int step = 1, string trend = "right")
{
    if (trend == "right" && step <= array.GetLength(0) * array.GetLength(1))
    {
        for (int k = j; k < array.GetLength(1) && array[i, k] == 0; k++)
        {
            array[i, k] = step;
            step++;
            j = k;
        }
        FillSpiralArray2d(array, i + 1, j, step, "down");
    }
    else if (trend == "down")
    {
        for (int k = i; k < array.GetLength(0) && array[k, j] == 0; k++)
        {
            array[k, j] = step;
            step++;
            i = k;
        }
        FillSpiralArray2d(array, i, j - 1, step, "left");
    }
    else if (trend == "left")
    {
        for (int k = j; k >= 0 && array[i, k] == 0; k--)
        {
            array[i, k] = step;
            step++;
            j = k;
        }
        FillSpiralArray2d(array, i - 1, j, step, "up");
    }
    else if (trend == "up")
    {
        for (int k = i; k >= 0 && array[k, j] == 0; k--)
        {
            array[k, j] = step;
            step++;
            i = k;
        }
        FillSpiralArray2d(array, i, j+1, step, "right");
    }
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

int[,] matr = new int[4, 4];
FillSpiralArray2d(matr);
PrintArray2d(matr);

