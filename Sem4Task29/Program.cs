// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// Вводим массив
int ReadData(string msg)
{
      Console.WriteLine(msg);
      int num = int.Parse(Console.ReadLine() ?? "0");
      return num;
}

// Создаем рандомный массив
int[] GenArr(int len, int min, int max)
{
      int[] arr = new int[len];
      Random rnd = new Random();
      for (int i = 0; i < len; i++)
      {
            arr[i] = rnd.Next(min, max + 1);
      }
      return arr;
}

// Печатаем результат
void PrintArray(int[] arr)
{
      Console.Write("[");
      for (int i = 0; i < arr.Length - 1; i++)
      {
            Console.Write(arr[i] + ", ");

      }
      Console.WriteLine(arr[arr.Length - 1] + "]");
}



int len = ReadData("длина массива: ");
int min = ReadData("Минимальное значение: ");
int max = ReadData("Максимальное значение: ");
int[] arr = GenArr(len, min, max);
PrintArray(arr);