/* Напишите программу, которая будет преобразовывать
десятичное число в двоичное.*/ 

// Вывод сообщения и запись введённых данных
int readData(string msg)
{
      Console.WriteLine(msg);
      int num = int.Parse(Console.ReadLine() ?? "0");
      return num;
}

//Переводим в двоичное
string DecToBin(int num)
{
    string line ="";
    while(num>0)
    {
        line = num%2+line;
        num=num/2;
    }
    return line;
}

//Печатаем результат
void PrintResult(string msg)
{
      Console.WriteLine(msg);
}

int num = readData("Введите число ");
PrintResult(DecToBin(num));
Console.WriteLine( Convert.ToString(num, 2));
Console.WriteLine( Convert.ToString(num, 8));
Console.WriteLine( Convert.ToString(num, 16));