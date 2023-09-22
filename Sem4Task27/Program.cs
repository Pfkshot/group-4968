/*  Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

//Вводим данные
int ReadData(string msg)
{
      Console.WriteLine(msg);
      int num = int.Parse(Console.ReadLine() ?? "0");
      return num;
}

//Печатаем результат
void PrintResult(string msg)
{
      Console.WriteLine(msg);
}

//Складываем числа

int SumDigit(int num)
{
      int res = 0;

      while (num > 0)
      {
            res = res + num % 10;

            num = num / 10;
      }

      return res;
}

int num = ReadData("Ввыедите число ");

int res = SumDigit(num);

PrintResult("Сумма цифр в числе равна " + res);

