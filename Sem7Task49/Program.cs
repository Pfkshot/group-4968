/*Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
и замените эти элементы на их квадраты.*/

//печатаем 
int readData(string msg)
{
      Console.WriteLine(msg);
      int num = int.Parse(Console.ReadLine() ?? "0");
      return num;
}
//Задем массив
int[,] Fill2DArray(int countRow, int countColumn, int topBorder, int downBorder)
{
      System.Random rnd = new System.Random();
      int[,] array2D = new int[countRow, countColumn];

      for (int i = 0; i < countRow; i++)
      {
            for (int j = 0; j < countColumn; j++)
            {
                  array2D[i, j] = rnd.Next(downBorder, topBorder);
            }
      }

      return array2D;
}
// печатаем массив
void Print2DArray(int[,] mtrx)
{
      for (int i = 0; i < mtrx.GetLength(0); i++)
      {
            for (int j = 0; j < mtrx.GetLength(1); j++)
            {
                  Console.Write(mtrx[i, j] + "\t");
            }
            Console.WriteLine();
      }
}
//Возводим в квадрат

void Update2DArray(int[,] mtrx)
{
      for (int i = 0; i < mtrx.GetLength(0); i = i + 2)
      {
            for (int j = 0; j < mtrx.GetLength(1); j = j + 2)
            {
                  mtrx[i, j] *= mtrx[i, j];
            }
      }
}

//Программа
int row = readData("Введите количество строк: ");
int column = readData("Введите количество столбцов: ");

int[,] arr2D = Fill2DArray(row, column, 100, 10);
Print2DArray(arr2D);
Update2DArray(arr2D);
Print2DArray(arr2D);