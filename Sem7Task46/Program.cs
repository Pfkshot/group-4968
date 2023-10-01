/*Задайте двумерный массив размером m×n,заполненный случайными целыми числами.*/

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

// void Print2DArray(int[,] matrix)
// {
//       for (int i = 0; i < matrix.GetLength(0); i++)
//       {
//             for (int j = 0; j < matrix.GetLength(1); j++)
//             {
//                   Console.Write(matrix[i, j] + " ");
//             }
//             Console.WriteLine();
//       }
// }
//Печатаем Массив
void Print2DArrayColor(int[,] matrix)
{
      ConsoleColor[] colors = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};


      for (int i = 0; i < matrix.GetLength(0); i++)
      {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                  Console.ForegroundColor = colors[new System.Random().Next(0, 16)];
                  Console.Write(matrix[i, j] + " ");
                  Console.ResetColor();
            }
            Console.WriteLine();
      }
}


//Программа
int row = readData("Введите количество строк: ");
int column = readData("Введите количество столбцов: ");

int[,] arr2D = Fill2DArray(row, column, 100, 10);
//Print2DArray(arr2D);
Print2DArrayColor(arr2D);

