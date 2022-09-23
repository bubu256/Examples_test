Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
int i = 2;
while (i <= num)
{
    Console.Write($"{i}, ");
    i+=2;
}