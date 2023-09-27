/*Напишите программу, которая перевернёт одномерный массив (последний элемент будет 
на первом месте, а первый - на последнем и т.д.)*/

//Генерация массива
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

//Переварачиваем массив вариант 1
int[] SwapNewArray(int[] arr)
{
      int[] outArr = new int[arr.Length];
      for (int i = 0; i < arr.Length; i++)
      {
            outArr[arr.Length - 1 - i] = arr[i];
      }
      return outArr;
}

//Переварачиваем массив вариант 2
void SwapArray(int[] arr)
{
      // int buferElement = 0;
      for (int i = 0; i < arr.Length / 2; i++)
      {
            (arr[arr.Length - 1 - i], arr[i]) = (arr[i], arr[arr.Length - 1 - i]);
            // buferElement = arr[arr.Length-1 - i];
            // arr[arr.Length-1 - i]=arr[i];
            // arr[i] = buferElement;
      }
}

//---------------------------------------------------------------

int[] arr = GenArray(15, 1, 100);
PrintArray(arr);
int[] swapArr = SwapNewArray(arr);
Console.WriteLine("Исходный массив");
PrintArray(arr);
Console.WriteLine("Перевернутый массив");
PrintArray(swapArr);

SwapArray(arr);
Console.WriteLine("Исходный массив");
PrintArray(arr);