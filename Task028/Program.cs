// напишите программу которая принимает на вход сило и выдает произведение числа от 1 до введенного числа
Console.WriteLine("Введите любое натуральное число");
int number = int.Parse(Console.ReadLine());
double mul = 1;
for (int i = 1; i <= number; i++)
{
    mul = mul * i;
}
Console.WriteLine($"Факториал числа {number} равен {mul}");