/*Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.*/

// Вывод сообщения и запись введённых данных
int readData(string msg)
{
      Console.WriteLine(msg);
      int num = int.Parse(Console.ReadLine() ?? "0");
      return num;
}

//Печатаем результат
void PrintResult(string msg)
{
      Console.WriteLine(msg);
}

// комплексный метод
(double x, double y) CrossPoint(double k1, double b1, double k2, double b2)
{
      double coorX1 = (b2 - b1) / (k1 - k2);
      double coorY1 = (k1 * b2 - k2 * b1) / (k1 - k2);
      return (coorX1, coorY1);
}

double K1 = readData("Input number K1: ");
double B1 = readData("Input number B1: ");
double K2 = readData("Input number K2: ");
double B2 = readData("Input number B2: ");
// Поиск координат пересечения
(double x, double y) pointA = CrossPoint(K1, B1, K2, B2);

double X1 = pointA.x;
double Y1 = pointA.y;

PrintResult($"Cross points of 2 lines: X1= {X1}; Y1= {Y1}");

