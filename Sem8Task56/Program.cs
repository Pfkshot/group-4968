/*Задайте прямоугольный двумерный массив. Напишите программу, которая будет 
находить строку с наименьшей суммой элементов.*/

//Задем массив от 1 до 10
void Fill2DArray(int[,] arr)
{
      for (int i = 0; i < arr.GetLength(0); i++)
      {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                  arr[i, j] = new Random().Next(1, 10);
            }
      }
}
// печатаем массив
void Print2DArray(int[,] arr)
{
      for (int i = 0; i < arr.GetLength(0); i++)
      {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                  Console.Write(arr[i, j] + "\t");
            }
            Console.WriteLine();
      }
}
// находим строку с наименьшей суммой элементов
void MinSumElemStr(int[,] arr)
{
      int minRow = 0;
      int minSumRow = 0;
      int[,] mtrx = new int[minRow, minSumRow];
      int sumRow = 0;
      for (int i = 0; i < mtrx.GetLength(1); i++)
      {
            minRow += mtrx[0, i];
      }
      for (int i = 0; i < mtrx.GetLength(0); i++)
      {
            for (int j = 0; j < mtrx.GetLength(1); j++) sumRow += mtrx[i, j];
            if (sumRow < minRow)
            {
                  minRow = sumRow;
                  minSumRow = i;
            }
            sumRow = 0;
      }
      Console.WriteLine("Номер строки с наименьшей суммой элементов : ");
      Console.Write(minSumRow + 1);
}

//Решение
int[,] mtrx = new int[4, 4];
Fill2DArray(mtrx);
Print2DArray(mtrx);
Console.WriteLine();
MinSumElemStr(mtrx);