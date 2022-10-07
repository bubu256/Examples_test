int[] array = { 2, 4, 7, 9 };
int n = array.Length;
int i = 0;
int find = 7;

while (i < n)
{
    if (array[i] == find)
    {
        Console.WriteLine(i);
        break;
    }
    i++;
}