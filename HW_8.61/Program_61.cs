// Задача 61: Показать треугольник Паскаля. *Сделать вывод в виде равнобедренного треугольника.


// принимает массив в качестве начала для расчета следующих строк
//      глубину т.е. сколько уровней строить согласно правилу треугольника паскаля
//      массив строк для записи результата
void PascalTriangleOutStringArray(int[] array, int level, string[] strResult)
{
    //if (strResult.Length != level + 1) strResult = new string[level + 1];

    //for (int i = 0; i < level-1; i++) Console.Write(" ");
    strResult[strResult.Length - level - 1] = string.Join(" ", array);
    if (level > 0)
    {
        int[] newArray = new int[array.Length + 1];
        newArray[0] = array[0];
        newArray[array.Length] = array[array.Length - 1];
        for (int i = 0; i < array.Length - 1; i++)
            newArray[i + 1] = array[i] + array[i + 1];
        PascalTriangleOutStringArray(newArray, level - 1, strResult);
    }
}


Console.Write("Введите глубину треугольника паскаля: ");
int deep = Int32.Parse(Console.ReadLine());
string[] strResult = new string[deep+1];
PascalTriangleOutStringArray(new int[] { 1 }, deep, strResult);


int maxLength = strResult[strResult.Length - 1].Length;
foreach (string row in strResult)
{   
    for (int i = 0; i < (maxLength - row.Length) / 2; i++)
        Console.Write(' ');
    Console.WriteLine(row);
}