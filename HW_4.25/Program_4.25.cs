// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int NaturalPow(int x, int power)
{   
    if (power < 1) 
    {
        Console.WriteLine("Введено не натуральное число.");
        return -1;
    }

    int res = x;
    for(int i=1; i < power; i++)
    {
        res = res * x;
    }
    return res;
}

int x = int.Parse(Console.ReadLine());
int y = int.Parse(Console.ReadLine());
Console.WriteLine(NaturalPow(x, y));
