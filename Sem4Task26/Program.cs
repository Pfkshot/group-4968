/*Напишите программу которая принимает на вход число и выдает количество чисел в числе 
*/

int ReadData(string msg)
{
      Console.WriteLine(msg);
      int num = int.Parse(Console.ReadLine() ?? "0");
      return num;
}

int NumDigits(int num)
{
      return Convert.ToInt32(Math.Log(num, 10) + 1);
}


int num = ReadData("Введите число");
Console.WriteLine("количество цифр в числе = " + NumDigits(num));