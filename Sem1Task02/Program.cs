Console.WriteLine("Введите число 1");
int num1 = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите число 2");
int num2 = int.Parse(Console.ReadLine() ?? "0");

if (num1 > num2)
{
              Console.WriteLine("Меньше Число " + num2);
}
if (num2 == num1)
{
              Console.WriteLine("Числа равны");
}
if (num1 < num2)
{
              Console.WriteLine("Меньше Число " + num1);
}

