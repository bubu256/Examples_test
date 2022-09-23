void FillArray(int[] coll)
{
    int n = coll.Length;
    int i = 0;
    while (i<n)
    {
        coll[i] = new Random().Next(1, 10);
        i++;
    }
}

void PrintArray(int[] arr)
{
    int i = 0;
    while (i < arr.Length)
    {
        Console.Write(arr[i]);
        i++;
    }
}

int IndexFind(int[] arr, int find)
{
    int i = 0;
    while (i < arr.Length)
    {
        if (arr[i] == find) 
        {
            return i;
        }
        i++;
    }
    return -1;
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine(IndexFind(array, 3));