/*Напишите программу, которая будет принимать 2 числа А и Ввозведите А в степень В 
с помощью рекурсии*/

int ReadData(string msg) // вводим данные
{
      Console.WriteLine(msg);
      int num = int.Parse(Console.ReadLine() ?? "0");
      return num;
}
// возводим в степень
long DigitPower(int n, int p)
{
      if (p == 1) return n;
      if (p == 2) return n * n;
      if (p > 0)
      {
            return DigitPower(n, p / 2) * DigitPower(n, p - p / 2);
      }
      else return 1;
}
int n = ReadData("Введите основание");
int m = ReadData("Введите степень");
Console.WriteLine(n + " в степени " + m + " = " + DigitPower(n, m));
