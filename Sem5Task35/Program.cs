/*
Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, 
значения которых лежат в отрезке [10,99]. 
*/

//задаем массив
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
//ищем числа от 10 до 99
int CountElm(int[] arr)
{
      int count = 0;
      for (int i = 0; i < arr.Length; i++)
      {
            if ((arr[i] >= 10) && (arr[i] <= 99))
                  count++;
      }
      return count;
}
//выдаем результат

//Печатаем результат
void PrintResult(string msg)
{
      Console.WriteLine(msg);
}

int[] arr = GenArray(123, 0, 500);
PrintArray(arr);
int count = CountElm(arr);
PrintResult(count + " элементов в заданном диапазоне");
