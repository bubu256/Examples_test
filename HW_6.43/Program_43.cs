// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Для двух функций: y = k1 * x + b1, y = k2 * x + b2; Задайте значения b1, k1, b2 и k2 (через Enter)");
        double b1 = double.Parse(Console.ReadLine());
        double k1 = double.Parse(Console.ReadLine());
        double b2 = double.Parse(Console.ReadLine());
        double k2 = double.Parse(Console.ReadLine());
        if (k1 == k2 && b1 != b2) Console.WriteLine($"Прямые параллельны не пересекаются");
        else if (k1 == k2 && b1 == b2) Console.WriteLine($"Прямые одинаковы и наложены друг на друга (все точки общие)");
        else
        {
            double x = (b2 - b1) / (k1 - k2);
            double y = k1 * x + b1;
            Console.WriteLine($"Точка пересечения прямых [{x},{y}]");
        }
        
    }
}