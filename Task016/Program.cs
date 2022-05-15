// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

Console.WriteLine("Является ли одно число квадратом другого");
Console.WriteLine("Введите первое число");
int firstNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе числа");
int secondNumber = int.Parse(Console.ReadLine());
//bool num1square = firstNumber * firstNumber == secondNumber;
//bool num2square = secondNumber * secondNumber == firstNumber;
Console.WriteLine(firstNumber * firstNumber == secondNumber || secondNumber * secondNumber == firstNumber ? "Да" : "Нет");
