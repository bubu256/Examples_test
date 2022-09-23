Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "маша")
{
    Console.WriteLine("Hello, Maria!!!");
}
else
{
    Console.Write("Hello, ");
    Console.Write(username);
}