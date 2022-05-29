// Задача 42: Напишите программу, которая будет преобразовывать
//десятичное число в двоичное.
//45 -> 101101
//3 -> 11
//2 -> 10
/*
int[] GetBinary(int num)
{
    int[] array = new int[8];
    int i = array.Length - 1;
    while (num > 0)
    {
        array[i] = num % 2;
        i--;
        num = num / 2;
    }
    return array;
}*/

Console.WriteLine("Введите десятичное число для перевода в двоичную систему: ");
int numDec = int.Parse(Console.ReadLine());
Console.WriteLine("Введите системы исчисления: ");
int baseNum = int.Parse(Console.ReadLine());
//int[] arr = GetBinary(numDec);
//Console.WriteLine(String.Join(" ", arr));

/*int d10 = 1;
long result = 0;
while (numDec != 0)
{
    result += numDec % baseNum * d10;
    numDec /= baseNum;
    d10 *= 10;
}

Console.WriteLine(result);*/

void DecToOther(int num, int baseN)
{
    if (num == 0)
    {
        return;
    }
    DecToOther(num / baseN, baseN);
    Console.Write(num % baseN);
}
DecToOther(numDec, baseNum);