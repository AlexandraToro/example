// Напишите программу, которая по
//заданному номеру четверти, показывает диапазон
//возможных координат точек в этой четверти (x и y).
Console.Write("Введите номер четверти: ");
int num = int.Parse(Console.ReadLine());

string Coord(int quart)
{
    string answer;
    switch (quart)
    {
        case 1: answer = "x > 0 и y > 0"; break;
        case 2: answer = "x < 0 и y > 0"; break;
        case 3: answer = "x < 0 и y < 0"; break;
        case 4: answer = "x > 0 и y < 0"; break;
        default: answer = "неверный ввод"; break;
    }
    /*if (quart == 1)
    {
        answer = "x > 0 и y> 0";
    }
    if (quart == 2)
    {
        answer = "x < 0 и y> 0";
    }
    if (quart == 3)
    {
        answer = "x < 0 и y<0";
    }
    if (quart == 4)
    {
        answer = "x > 0 и y<0";
    }
    else
    {
        answer = "неверный ввод";
    }*/

    return answer;
}
Console.WriteLine(Coord(num));