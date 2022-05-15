int num = new Random().Next(100, 1000);
Console.WriteLine(num);
int firstDigit = num / 100;
int secondDigit = num % 10;
Console.WriteLine($"{firstDigit}{secondDigit}");

Console.WriteLine(num/100*10+num%10);