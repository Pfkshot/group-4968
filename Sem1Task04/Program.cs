Console.WriteLine("Введите число 1");
int num1 = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите число 2");
int num2 = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите число 3");
int num3 = int.Parse(Console.ReadLine() ?? "0");

int max = num1;

if (num1 > max) max = num1;
if (num2 > max) max = num2;
if (num3 > max) max = num3;

Console.WriteLine("max = " + max);