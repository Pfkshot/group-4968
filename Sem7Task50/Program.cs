/*Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали
 (с индексами (0,0); (1;1) и т.д.*/

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
//Находим сумму чисел на главной диагонали
int MainDiagSum(int[,] mtrx)
{
      int res = 0;
      int min = mtrx.GetLength(0);
      if (min > mtrx.GetLength(1)) min = mtrx.GetLength(1);
      for (int i = 0; i < min; i++)
      {
            res = res + mtrx[i, i];
      }

      return res;
}

//Печатаем ответ
void PrintResult(string msg)
{
      Console.WriteLine(msg);
}
//программа

//задаем кол-во строк и столбцов
int row = readData("Введите количество строк: ");
int column = readData("Введите количество столбцов: ");
//Печатаем решение
int[,] arr2D = Fill2DArray(row, column, 100, 10);
Print2DArray(arr2D);
int sum = MainDiagSum(arr2D);
PrintResult("Сумма чисел на главной диагонали = " + sum);