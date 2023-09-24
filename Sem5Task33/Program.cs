/*
Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число 
в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да
*/

// Вывод сообщения и запись введённых данных
int readData(string msg)
{
      Console.WriteLine(msg);
      int num = int.Parse(Console.ReadLine() ?? "0");
      return num;
}

// Проверяет, есть ли число
string Check(int[] array, int num)
{
      for (int i = 0; i < array.Length; i++)
            if (array[i] == num)
                  return $"Есть, индекс {i}";
      return "Нет";
}

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

int[] array = GenArray(12, -9, 9);
PrintArray(array);

int element = readData("Введите число для поиска: ");

Console.WriteLine(Check(array, element));