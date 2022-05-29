/*Задача 33: Задайте массив. Напишите программу, которая
определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да*/
Console.WriteLine("Введите искомое число: ");
int number = int.Parse(Console.ReadLine());
int[] nums = new int[10];
Random numRnd = new Random();
for (int i = 0; i < nums.Length; i++)
{
    nums[i] = numRnd.Next(-20, 21);
    Console.Write(nums[i] + " ");
}
bool res = false;
for (int i = 0; i < nums.Length; i++)
{
    if (nums[i] == number)
    {
        res = true;
        break;
    }
}
Console.WriteLine();
Console.WriteLine(res ? "В данном массиев найдено заданное число" : "В данном массиве не найдено заданное число");
