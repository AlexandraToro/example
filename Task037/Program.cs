/*Найдите произведение пар чисел в одномерном массиве.
Парой считаем первый и последний элемент, второй и предпоследний
и т.д. Результат запишите в новом массиве*/

int[] nums = new int[10];
Random numRnd = new Random();
for (int i = 0; i < nums.Length; i++)
{
    nums[i] = numRnd.Next(0, 5);
    Console.Write(nums[i] + " ");
}

int size= nums.Length%2==0? nums.Length/2: nums.Length/2+1;

int[] arr=new int[size];

for (int i = 0; i < nums.Length; i++ )
{
    arr[i]= nums[i]*nums[nums.Length-1-i];    
}
string st=string.Join(", ", arr);
Console.WriteLine(st);