// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// вывод элементов трехмерного массива с указанием индексов в скобках
void PrintArray3dWithIndex(int[,,] array3d)
{
    for (int i = 0; i < array3d.GetLength(0); i++)
        for (int j = 0; j < array3d.GetLength(1); j++)
            for (int k = 0; k < array3d.GetLength(2); k++)
                Console.WriteLine($"{array3d[i, j, k]} ({i},{j},{k})");
}

// создание и заполнение массива
int[,,] array3d = new int[3, 3, 3];
int number = new Random().Next(10, 99 - 3 * 3 * 3);
for (int i = 0; i < array3d.GetLength(0); i++)
    for (int j = 0; j < array3d.GetLength(1); j++)
        for (int k = 0; k < array3d.GetLength(2); k++)
        {
            array3d[i, j, k] = number;
            number++;
        }
// вывод
PrintArray3dWithIndex(array3d);