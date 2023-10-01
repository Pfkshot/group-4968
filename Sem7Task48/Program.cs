/*Задайте двумерный массив размера m на n,каждый элемент в массиве находится по формуле:
 Aₘₙ = m+n.Выведите полученный массив на экран.*/

//печатаем 
int readData(string msg)
{
      Console.WriteLine(msg);
      int num = int.Parse(Console.ReadLine() ?? "0");
      return num;
}
//Задем массив
int[,] Fill2DSumInd(int row, int column)
{
      int[,] arr = new int[row, column];

      for (int i = 0; i < row; i++)
      {
            for (int j = 0; j < column; j++)
            {
                  arr[i, j] = i + j;
            }
      }

      return arr;
}
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
                  Console.Write(matrix[i, j] + "\t");
                  Console.ResetColor();
            }
            Console.WriteLine();
      }
}


//Программа
int row = readData("Введите m: ");
int column = readData("Введите n: ");

int[,] arr = Fill2DSumInd(row, column);
Print2DArrayColor(arr);

