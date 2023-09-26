/* Задайте массив заполненный случайными положительными трёхзначными числами. Напишите
программу, которая покажет количество чётных чисел в массиве.*/

//Создаем масив
int[] GenArray(int num, int lowBorder, int highBorder)
{
      int[] array = new int[num];
      for (int i = 0; i < num; i++)
      {
            array[i] = new Random().Next(lowBorder, highBorder + 1);
      }
      return array;
}
//Печать массива
void PrintArray(int[] arr)
{
      Console.Write("[");
      for (int i = 0; i < arr.Length - 1; i++)
      {
            Console.Write(arr[i] + ", ");

      }
      Console.WriteLine(arr[arr.Length - 1] + "]");
}

//Печатаем результат
void PrintResult(string msg)
{
      Console.WriteLine(msg);
}

// Считаем четные числа
int CountEvn(int[] arr)
{
      int count = 0;

      for (int i = 0; i < arr.Length; i++)
      {
            if (arr[i] % 2 == 0)
            {
                  count++;
            }
      }

      return count;
}

int[] arr = GenArray(12, 100, 999);
PrintArray(arr);
int count = CountEvn(arr);
PrintResult("Количество четных чисел в массиве = " + count);