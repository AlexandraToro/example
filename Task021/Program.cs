// 
Console.WriteLine("Ввод координаты x точки А");
int xA = int.Parse(Console.ReadLine());
Console.WriteLine("Ввод координаты y точки А");
int yA = int.Parse(Console.ReadLine());
Console.WriteLine("Ввод координаты x точки B");
int xB = int.Parse(Console.ReadLine());
Console.WriteLine("Ввод координаты y точки B");
int yB = int.Parse(Console.ReadLine());

float getDist(int x1, int y1, int x2, int y2)
{
    float result = (float)(Math.Sqrt((Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2))));
    return result;
}

Console.WriteLine("{0: 0.00}", getDist(xA, yA, xB, yB));