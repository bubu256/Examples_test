// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

bool IsPolyndrom(string str)
{
    string strRevers = String.Empty;
    for(int i = str.Length - 1; i >= 0; i--)
    {
        strRevers += str[i];
    }

    if (str == strRevers) return true;

    return false;
}

if(IsPolyndrom(Console.ReadLine()))
{
    Console.WriteLine("да");
}
else Console.WriteLine("нет");
