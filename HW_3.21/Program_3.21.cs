// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B(2, 1, -7), -> 15.84
// A(7, -5, 0); B(1, -1, 9)-> 11.53

// ввод координаты точки от пользователя
int[] InputVector()
{
    int[] vector = new int[3];
    for(int i = 0; i < 3; i++)
    {
        vector[i] = int.Parse(Console.ReadLine());
    }
    return vector;
}

// подсчет расстояние между х и у
double Distance(int[] x, int[] y)
{
    double result = 0;
    for(int i = 0; i < x.Length; i++)
    {
        result += Math.Pow(x[i] - y[i], 2);
    }
    return Math.Sqrt(result);
}

Console.WriteLine("Введите координаты точки А: ");
int[] a = InputVector();
Console.WriteLine("Введите координаты точки B: ");
int[] b = InputVector();

Console.WriteLine($"Расстояние между точками: {Distance(a, b)}");

