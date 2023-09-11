// Напишите программу, которая принимает на вход трёхзначное число и на выходе
// показывает вторую цифру этого числа. 

//Гененрирование рандомного 3хзначного числа
int ran = new System.Random().Next(100, 1000);
System.Console.WriteLine(ran);
// Создаем переменную
char[] digitChar = ran.ToString().ToCharArray();
// выводим 2ю цифру 
System.Console.Write(digitChar[1]);
