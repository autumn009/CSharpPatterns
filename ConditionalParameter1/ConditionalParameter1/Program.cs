var dateTime = new DateTime(2023, 11, 5);
var dateTime2 = new DateTime(2023, 11, 6);
if (isSunday(dateTime)) Console.WriteLine("パターン1:今日は日曜日!");
if (isDayOfWeek(dateTime, DayOfWeek.Sunday)) Console.WriteLine("パターン2:今日は日曜日!");
if (isDayOfWeek(dateTime2, DayOfWeek.Monday)) Console.WriteLine("パターン2:今日は月曜日!");

// パターン1　日曜日判定専用
bool isSunday(DateTime dateTime)
{
    return dateTime.DayOfWeek == DayOfWeek.Sunday;
}
// パターン2　任意の曜日判定
bool isDayOfWeek(DateTime dateTime, DayOfWeek dayOfWeek)
{
    return dateTime.DayOfWeek == dayOfWeek;
}
