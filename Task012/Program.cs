// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
//34, 5 -> не кратно, остаток 4
//16, 4 -> кратно
Console.WriteLine("Определние кратности двух чисел");
Console.WriteLine("Введите первое числа");
int firstNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе числа");
int secondNumber = int.Parse(Console.ReadLine());
Console.WriteLine (firstNumber%secondNumber == 0 ? $" {firstNumber}, {secondNumber} - > кратно" : $" {firstNumber}, {secondNumber} - > не кратно, остаток = {firstNumber%secondNumber}");