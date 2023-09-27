/*Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным
элементами массива.*/

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

//ищем min и max значения
int Dif(int[] arr)
{
      int min = arr[0];
      int max = arr[0];

      for (int i = 0; i < arr.Length; i++)
      {
            if (arr[i] < min) min = arr[i];
            if (arr[i] > max) max = arr[i];
      }

      return max - min;
}

int[] arr = GenArray(10, 0, 100);
PrintArray(arr);
int Diff = Dif(arr);
PrintResult("Разницу между максимальным и минимальным элементами массива = " + Diff);