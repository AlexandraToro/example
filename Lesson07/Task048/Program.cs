int[,] GetArray(int n, int m)

{
    int[,] array = new int[n, m];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(1, 20);
        }
    }
    return array;
}

void PrintArray(int[,] array)

{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите количество строк: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int m = int.Parse(Console.ReadLine());
int [,] arrayResult= GetArray(n,m);
PrintArray(arrayResult);