/*Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.*/

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

// вызов метода Аккермана
void AkkermanFunction(int m, int n)
{
      Console.Write(Akkerman(m, n));
}

// Метод Аккермана
int Akkerman(int m, int n)
{
      if (m == 0)
      {
            return n + 1;
      }
      else if (n == 0 && m > 0)
      {
            return Akkerman(m - 1, 1);
      }
      else
      {
            return (Akkerman(m - 1, Akkerman(m, n - 1)));
      }
}

//Решение

int m = ReadData("Введите число m "); ;
int n = ReadData("Введите число n ");
PrintResult("Функция Аккермана  ");
AkkermanFunction(m, n);
