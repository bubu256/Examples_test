// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

string IntArrayToString(int[] arr)
{
    string str = "[" + arr[0];
    for(int i = 1; i < arr.Length; i++)
    {
        str += ", " + arr[i];
    }
    return str + "]";
}

// правильно ли я тут работаю с паматью?
// несмог найти хороший способ находу добавлять новые элементы в массив илиже делать срез как в питоне
int[] ReadArrayInt(string str) 
{
    int[] result_temp = new int[30]; // выделяю память с запасом
    int countInt = 0;
    string temp = string.Empty;
    for(int i=0; i < str.Length; i++)
    {
        if (str[i]==' ')
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
    for(int i=0; i < countInt; i++) result[i] = result_temp[i]; // переписываю туда найденые числа
    return result; // возвращаем result в котором нет лишней памяти
}

Console.Write("Введите целые числа чез знак пробела: ");
int[] array = ReadArrayInt(Console.ReadLine());
Console.WriteLine(IntArrayToString(array));

