// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0


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
int[] numbers = new int[4];
var rnd = new Random();
for(int i = 0; i< numbers.Length; i++)
{
    numbers[i] = (int)(rnd.Next(-100, 100));
}

// посмотрим на созданный массив
PrintIntArray(numbers);

// пройдем по нечетным позициям и суммирую их
int num_sum = 0;
for(int i = 1; i < numbers.Length; i+=2)
{
    num_sum += numbers[i];
}
Console.WriteLine($"Сумма элементов на нечетных позицыях = {num_sum}");