/*Найдите произведение пар чисел в одномерном массиве.
Парой считаем первый и последний элемент, второй и предпоследний
и т.д. Результат запишите в новом массиве.*/;

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

//Конвертация
int [] ConvertArr(int[] arr)
{
      int[] outArr = new int[arr.Length/2];

      for(int i =0; i < arr.Length/2; i++)
      {
           outArr[i] = arr[i]* arr[arr.Length-1 -i]; 
      }
      return outArr;
}
//результат
int[] arr = GenArray(20, 0, 50);
PrintArray(arr);
PrintArray(ConvertArr(arr));