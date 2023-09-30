/*Пользователь вводит с клавиатуры M чисел. Посчитайте,
 сколько чисел больше 0 ввёл пользователь.*/

//печатаем число
int readData(string msg)
{
      Console.WriteLine(msg);
      int num = int.Parse(Console.ReadLine() ?? "0");
      return num;
}

//Создаем масив
int[] GenArray(int length)
{
      int[] array = new int[length];
      for (int i = 0; i < array.Length; i++)
      {
            array[i] = readData("Введите " + (i + 1) + "-й элемент");
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
//ищем числа больше нуля
int CountPosNum(int[] arr)
{
      int count = 0;
      for (int i = 0; i < arr.Length; i++)
      {
            if (arr[i] > 0)
            {
                  count++;
            }
      }

      return count;
}

void PrintResult(string msg)
{
      Console.WriteLine(msg);
}

int length = readData("Введите количество элементов");
int[] arr = GenArray(length);
PrintArray(arr);
int count = CountPosNum(arr);
PrintResult("Количество чисел > 0 = " + count);

