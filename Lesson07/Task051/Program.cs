// See https://aka.ms/new-console-template for more information

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
/*
int GetDiagSumArray(int[,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == j) sum += array[i, j];
        }
    }
    return sum;
}*/

int GetDiagSumArray(int[,] array)
{
    int n = 0;
    int sum = 0;
    if (array.GetLength(0) < array.GetLength(1))
        n = array.GetLength(0);
    else n = array.GetLength(1);
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, i];
        }
    }
    return sum;
}

Console.WriteLine("Введите количество строк: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int m = int.Parse(Console.ReadLine());
int[,] arrayResult = GetArray(n, m);
PrintArray(arrayResult);
int res = GetDiagSumArray(arrayResult);
Console.WriteLine($"Сумма цифр по диагонали равна {res}");
