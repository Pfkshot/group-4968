// день недели по номеру

Console.WriteLine("Enter day number");

int dayNum = int.Parse(Console.ReadLine());

string outDayOfWeek = System.Globalization.CultureInfo.GetCultureInfo("ru-RU").DataTimeFormate.GetDayName((DayOfWeek)Enum.GetValues(typeof(DayOfWeek)).GetValue(dayNum));

Console.WriteLine(outDayOfWeek);