// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

// ф-ция вывода массива
void PrintIntArray(int[] arr)
{
    string str = "[" + arr[0];
    for(int i = 1; i < arr.Length; i++)
    {
        str += ", " + arr[i];
    }
    Console.WriteLine(str + "]");
}


// создаем и заполняем массив
int[] numbers = new int[10];
var rnd = new Random();
for(int i = 0; i< numbers.Length; i++)
{
    numbers[i] = (int)(rnd.NextDouble()*(999-100) + 100);
}
// посмотрим на созданный массив
PrintIntArray(numbers);

// считаем четные числа 
int сount_num_of_even = 0;
for(int i = 0; i< numbers.Length; i++)
{
    if (numbers[i]%2 == 0)
    {
        сount_num_of_even++;
    }
}

Console.WriteLine($"Количество четных чисел: {сount_num_of_even}");

