// Задача 59: Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.

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

// возвращает массив без строки и колонки i j
int[,] DropColumnRow(int[,] array, int index_i, int index_j)
{
    int[,] result = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    int i_corrector = 0, j_corrector = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (i == index_i)
        {
            i_corrector--;
            continue;
        }
        j_corrector = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == index_j)
            {
                j_corrector--;
            }
            else
                result[i + i_corrector, j + j_corrector] = array[i, j];
            
        }
    }
    return result;
}

// возвращает кортеж i j мин элемента массива
(int, int) GetMinIndexes(int[,] array)
{
    int min = array[0,0];
    int iMin = 0;
    int jMin = 0;
    for(int i = 0; i<array.GetLength(0); i++)
        for(int j=0; j<array.GetLength(1); j++)
        {
            if(array[i,j]<min) 
            {
                iMin = i;
                jMin = j;
                min = array[i,j];
            }
        }
    
    return (iMin, jMin);
}

// создаем массив
int[,] matr = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 0, 9 } };
Console.WriteLine("Дано:");
PrintArray2d(matr);

// берем индексы
(int i, int j) = GetMinIndexes(matr);
Console.WriteLine("Результат:");

// выводим массив с удаленными данными
PrintArray2d(DropColumnRow(matr, i, j));