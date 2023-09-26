/*Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
стоящих на нечётных позициях.*/

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
// Ищем сумму элементов, стоящих на нечётных позициях

int SumNegPos(int[] arr)
{
      int Sum = 0;
      for (int i = 1; i < arr.Length; i = i + 2)
      {
            Sum = Sum + arr[i];
      }

      return Sum;
}

int[] arr = GenArray(15, 0, 100);
PrintArray(arr);
int sum = SumNegPos(arr);
PrintResult("Сумма элементов, стоящих на нечётных позициях = " + sum);
