/*Задайте значение N. Напишите программу, которая выведет все натуральные числа в 
промежутке от N до 1. Выполнить с помощью рекурсии.*/
// вводим данные
int ReadData(string msg)
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
//Ищем натуральные числа
void NatDig(int n, int count)
{
    if (count > n)
    {
        return;
    }
    else
    {
        NatDig(n, count + 1);
        Console.Write(count + " ");
    }
}
//Решение
int count = 1;
int num = ReadData("Введите число N ");
PrintResult("Натуральные числа в промежутке это: ");
NatDig(num, count);
