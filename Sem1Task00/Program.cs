// Задача0
// Напишите программу, котрая на вход принимает число и
// выдает его квадрат(число уможенное само на себя)

Console.WriteLine("Введите число: ");
//ссчитываем данные с консоли
//string iputNum = Console.ReadLine()??"0";  если ругается на null замена текста ниже

string? iputNum = Console.ReadLine();
//Проверяем, чтобы данные были не пустыми
if (iputNum != null)
{
              // // Парсим введеное число
              // int num = int.Parse(iputNum);
              // // Находим квадрат числа        
              // int res = num * num;
              // // Выводим данные в консоль
              // Console.WriteLine(res);

              Console.WriteLine("Квадрат числа: " + (int)Math.Pow(int.Parse(iputNum), 2));
}

