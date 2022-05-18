// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());

void TablQuart(int number)
{
Console.WriteLine("|{0,10}|{1,10}|", "Число", "Квадрат числа");
for (int count = 1; count <= num; count++)
{
    Console.WriteLine("|{0,10}|{1,13}|", count, count * count);
}
}
TablQuart(num);