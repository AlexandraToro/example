/*Напишите программу, которая принимает на вход три
числа и проверяет, может ли существовать треугольник с сторонами
такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника
меньше суммы двух других сторон.*/

void Triangle(int a, int b, int c)
{
    if (a < b + c && b < a + c && c < a + b) 
    Console.WriteLine("Треугольник с данными сторонами может существовать.");
    else 
    Console.WriteLine("Треугольник с данными сторонами не может существовать.");
}

Console.WriteLine("Введите длину первого отрезка: ");
int len1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите длину второго отрезка: ");
int len2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите длину третьего отрезка: ");
int len3 = int.Parse(Console.ReadLine());

Triangle(len1, len2,len3);