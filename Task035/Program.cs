/*Задача 35: Задайте одномерный массив из 123 случайных чисел.
Найдите количество элементов массива, значения которых лежат в
отрезке [10,99].*/
int[] nums = new int[123];
Random numRnd = new Random();
int counter = 0;
for (int i = 0; i < nums.Length; i++)
{
    nums[i] = numRnd.Next(0, 250);
    if (nums[i] > 9 && nums[i] < 100) counter++;
}
Console.WriteLine($"Количество элементов массива, значания которых лежат в отрезке от 10 до 99 равно {counter}");