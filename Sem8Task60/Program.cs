/*Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.Напишите программу, 
которая будет построчно выводить массив, добавляя индексы каждого элемента.*/

//заполняем массив
void Fill3DIndex(int[,,] arr)
{
      int count = 10;
      for (int i = 0; i < arr.GetLength(0); i++)
      {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                  for (int a = 0; a < arr.GetLength(2); a++)
                  {
                        arr[a, i, j] += count;
                        count += 3;
                  }
            }
      }
}
// Печатаем индексы масива
void Print3DArray(int[,,] arr)
{
      for (int i = 0; i < arr.GetLength(0); i++)
      {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                  Console.WriteLine();
                  for (int k = 0; k < arr.GetLength(2); k++)
                  {
                        Console.Write($"{arr[i, j, k]}({i},{j},{k}) ");
                  }
            }
      }
}


int[,,] array3D = new int[2, 2, 2];
Fill3DIndex(array3D);
Print3DArray(array3D);
