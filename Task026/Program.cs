// 
Console.WriteLine("Введите любое натуральное число: ");
int number = int.Parse(Console.ReadLine());
int i = 0;
Console.Write($"Количество цифр в числе {number} равно ");
while (number > 0)
{
    number = number / 10;
    i++;
}
Console.WriteLine (i);
