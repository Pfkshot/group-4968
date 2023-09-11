/* Напишите программу, которая принимает на вход цифру, обозначающую день недели,
и проверяет, является ли этот день выходным. */

Console.WriteLine("Enter day number ");

int day = int.Parse(Console.ReadLine() ?? "0");

string[] dayOfWeek = new string[7];

dayOfWeek[0] = "Понедельник";
dayOfWeek[1] = "Вторник";
dayOfWeek[2] = "Среда";
dayOfWeek[3] = "Четверг";
dayOfWeek[4] = "Пятница";
dayOfWeek[5] = "Суббота";
dayOfWeek[6] = "Воскресенье";


if (day >= 1 && day <= 5)
{
      Console.WriteLine(dayOfWeek[day - 1] + " это рабочий день");
}
else
{
      Console.WriteLine(dayOfWeek[day - 1] + " это выходной");
}
