//  Напишите программу, которая будет создавать
//копию заданного массива с помощью поэлементного
//копирования.

void GetCopyArray(int[] arr)
{
    int[] copyArray = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        copyArray[i] = arr[i];
    }
    var str = String.Join(" ", copyArray);
    Console.WriteLine(str);
}
Console.WriteLine("Введите элементы массива через пробел: ");
int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
GetCopyArray(array);