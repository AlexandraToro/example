
int num = new Random().Next(10, 100);
Console.WriteLine(num);

//int firstDigit = num / 10;
//int secondDigit = num % 10;
//if (firstDigit > secondDigit) Console.WriteLine ($" Max = {firstDigit}");
//else Console.WriteLine($" Max = {secondDigit}");

//Console.WriteLine(firstDigit > secondDigit ? $" Max = {firstDigit}" : $"Max = {secondDigit}");

//string res = firstDigit > secondDigit ? $" Max = {firstDigit}" : $"Max = {secondDigit}";
//Console.WriteLine(res);
int  maxNumber  = GetMaxDigit (num);
Console.WriteLine(maxNumber);

int GetMaxDigit(int number)
{
    int firstDigit = number / 10;
    int secondDigit = number % 10;
    return firstDigit > secondDigit ? firstDigit : secondDigit;
}