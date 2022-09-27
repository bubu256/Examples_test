// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SumCount(int number)
{
    int result = number%10;
    while (number > 10)
    {
        number = number / 10; //тип int поэтому деление целочисленное
        result += number%10;
    }    
    return result;
}
int x = int.Parse(Console.ReadLine());
Console.WriteLine(SumCount(x));
