// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите любое натуральное число");
int number = int.Parse(Console.ReadLine());
int sum = 0;
for (int i = 1; i <= number; i++)
{
    sum = sum + i;
}
Console.WriteLine($"{number} -> {sum}");