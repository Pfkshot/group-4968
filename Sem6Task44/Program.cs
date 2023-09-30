/*Не используя рекурсию, выведите первые N чисел Фибоначчи. 
Первые два числа Фибоначчи: 0 и 1.*/

//печатаем число
int readData(string msg)
{
      Console.WriteLine(msg);
      int num = int.Parse(Console.ReadLine() ?? "0");
      return num;
}

//Печать числа фибоначи
void PrintFibNum(int num)
{
      int buf = 0;
      int first = 0;
      int second = 1;
      Console.Write(first + "_" + second);
      for (int i = 2; i < num; i++)
      {
            Console.Write("_" + (first + second));
            buf = first + second;
            first = second;
            second = buf;
      }
}
//Тело программы
int N = readData("Введите количество чисел Фибоначчи (N): ");
PrintFibNum(N);