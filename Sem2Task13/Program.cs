/* Напишите программу, которая выводит третью цифру заданного числа или сообщает,
что третьей цифры нет*/

// Вводим число

int ThirdDigit(int number)
{
      int result = -1;
      if (number >= 100)
      {
            while (number > 999)
            {
                  number = number / 10;
            }
            result = number % 10;
      }
      return result;
}

Console.Write("Введите число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

if (ThirdDigit(number1) == -1)
{
      Console.WriteLine("третьей цифры нет");
}
else
{
      Console.WriteLine("Третья цифра это " + ThirdDigit(number1));
}

// string line = (Console.ReadLine() ?? "0");

// char[] digits = line.ToCharArray();

// Console.WriteLine(digits[2]);
