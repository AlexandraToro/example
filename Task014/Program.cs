// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
Console.WriteLine("Определние кратности 7  и 23");
Console.WriteLine("Введите чисоj");
int number = int.Parse(Console.ReadLine());
Console.WriteLine (number%7 == 0 && number%23 == 0 ? $" {number}- > кратно" : $" {number} - > не кратно");