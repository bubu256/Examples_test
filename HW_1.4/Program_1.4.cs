Console.WriteLine("Введите три числа: ");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());
Console.WriteLine($"Максимальное число: {Math.Max(Math.Max(a, b), c)}");