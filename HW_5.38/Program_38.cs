// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

// ф-ция вывода массива
void PrintDoubleArray(double[] arr)
{
    string str = "[" + arr[0];
    for(int i = 1; i < arr.Length; i++)
    {
        str += ", " + arr[i];
    }
    Console.WriteLine(str + "]");
}

// ф возвращает максимум
double MaxOfArray(double[] arr)
{
    double max = arr[0];
    for(int i = 1; i < arr.Length; i++)
    {
        if (max < arr[i]) max = arr[i];
    }
    return max;
}

// ф возвращает минимум
double MinOfArray(double[] arr)
{
    double min = arr[0];
    for(int i = 1; i < arr.Length; i++)
    {
        if (min > arr[i]) min = arr[i];
    }
    return min;
}

// создаем и заполняем массив
double[] numbers = new double[5];
var rnd = new Random();
for(int i = 0; i < numbers.Length; i++)
{
    numbers[i] = rnd.NextDouble();
}
// посмотрим на созданный массив
PrintDoubleArray(numbers);


Console.WriteLine($"Разница максимального и минимального числа = {MaxOfArray(numbers) - MinOfArray(numbers)}");