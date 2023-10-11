/*Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов 
в промежутке от M до N.*/

// вводим данные
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

//Ищем сумму натуральных чисел
int Sum(int m, int n)
{
      int res = m;
      if (m == n)
            return 0;
      else
      {
            m++;
            res = m + Sum(m, n);
            return res;
      }
}

void SumNatural(int m, int n)
{
      Console.Write(Sum(m - 1, n));
}

//Решение
int m = ReadData("Введите число m "); ;
int n = ReadData("Введите число n ");
PrintResult("Сумма натуральных чисел равна  ");
SumNatural(m, n);