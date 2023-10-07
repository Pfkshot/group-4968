/*Задайте две матрицы. Напишите программу, которая будет находить произведение\
 двух матриц.*/

int readData(string msg)
{
      Console.WriteLine(msg);
      int num = int.Parse(Console.ReadLine() ?? "0");
      return num;
}

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

int rows = readData("Введите количество строк: ");
int columns = readData("Введите количество столбцов: ");
int[,] arr = new int[rows, columns];
int[,] secondArr = new int[rows, columns];
int[,] resultArr = new int[rows, columns];

Fill2DArray(arr);
Print2DArray(arr);

Console.WriteLine();

Fill2DArray(secondArr);
Print2DArray(secondArr);

Console.WriteLine();

if (arr.GetLength(0) != secondArr.GetLength(1))
{
      Console.WriteLine(" Нельзя перемножить ");
      return;
}
for (int i = 0; i < arr.GetLength(0); i++)
{
      for (int j = 0; j < secondArr.GetLength(1); j++)
      {
            resultArr[i, j] = 0;
            for (int k = 0; k < arr.GetLength(1); k++)
            {
                  resultArr[i, j] += arr[i, k] * secondArr[k, j];
            }
      }
}

Print2DArray(resultArr);