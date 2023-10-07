/*Задайте двумерный массив. Напишите программу, которая упорядочит
 по убыванию элементы каждой строки двумерного массива.*/

//методы

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
// Сортировка
void SortArr(int[,] arr)
{
      for (int i = 0; i < arr.GetLength(0); i++)
      {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                  for (int k = 0; k < arr.GetLength(1) - 1; k++)
                  {
                        if (arr[i, k] < arr[i, k + 1])
                        {
                              int buf = arr[i, k + 1];
                              arr[i, k + 1] = arr[i, k];
                              arr[i, k] = buf;
                        }
                  }
            }
      }
}

int[,] mtrx = new int[3, 4];
Fill2DArray(mtrx);
Print2DArray(mtrx);
SortArr(mtrx);
Console.WriteLine("-----------------------------------------");
Print2DArray(mtrx);

