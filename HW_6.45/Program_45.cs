// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

// ф-ция считывает массив из строки с числами через пробел
int[] ConvertStringToArrayInt(string str)
{
    int[] result_temp = new int[30]; // выделяю память с запасом
    int countInt = 0;
    string temp = string.Empty;
    for (int i = 0; i < str.Length; i++)
    {
        if (str[i] == ' ')
        {
            result_temp[countInt] = int.Parse(temp);
            countInt++;
            temp = string.Empty;
        }
        else temp += str[i];
    }
    if (temp.Length > 0)
    {
        result_temp[countInt] = int.Parse(temp);
        countInt++;
    }

    int[] result = new int[countInt]; // выделяю память для финальных данных
    for (int i = 0; i < countInt; i++) result[i] = result_temp[i]; // переписываю туда найденные числа
    return result; // возвращаем result в котором нет лишней памяти
}

// ф-ция вывода массива
void PrintIntArray(int[] arr)
{
    string str = "[" + arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        str += ", " + arr[i];
    }
    Console.WriteLine(str + "]");
}

Console.Write("Введите массив int через пробел: ");
int[] array = ConvertStringToArrayInt(Console.ReadLine());
// копируем массив
int[] array_copy = new int[array.Length];
for(int i=0; i<array.Length; i++)
{
    array_copy[i] = array[i];
}

Console.Write("Массив скопирован: ");
PrintIntArray(array_copy);