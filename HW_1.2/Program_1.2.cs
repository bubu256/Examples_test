Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine());

if (a < b)
{
    Console.WriteLine($"Число {b} больше {a}");
}
else if (a > b)
{
    Console.WriteLine($"Число {a} больше {b}");
}
else
{
    Console.WriteLine("Числа равны!");
}