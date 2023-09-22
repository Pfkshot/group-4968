/*№25 Напишите цикл, который принимает на вход два числа (A и B) и 
возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
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

//Возведение в степень
long MyPow(int A, int B)
{
      long res = 1;
      while (B > 0)
      {
            res = res * A;
            B = B - 1;
      }
      return res;
}

int A = ReadData("Введите число A: ");
int B = ReadData("Введите число B: ");

long res = MyPow(A, B);

PrintResult(A + " в степени " + B + " равно: " + res);