/*Напишите программу, которая будет создавать копию заданного массива с помощью 
поэлементного копирования.*/

int[] GenArray(int num, int lowBorder, int highBorder)
{
      int[] arr = new int[num];
      for (int i = 0; i < num; i++)
      {
            arr[i] = new Random().Next(lowBorder, highBorder + 1);
      }
      return arr;
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

// Создаёт копию заданного массива с помощью поэлементного копирования
int[] CopyArray(int[] arr)
{
      int[] copiedArr = new int[arr.Length];

      // перебор элементов 
      for (int i = 0; i < arr.Length; i++)
            copiedArr[i] = arr[i];

      return copiedArr;
}

//тело программы
int[] arr = GenArray(15, 0, 100);
PrintArray(arr);
int[] copiedArr = CopyArray(arr);
PrintArray(copiedArr);
