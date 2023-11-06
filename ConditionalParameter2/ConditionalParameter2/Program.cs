var dateTime = new DateTime(2023, 11, 5);
var dateTime2 = new DateTime(2023, 11, 6);
if (isDateTime(dateTime, (dateTime) => dateTime.DayOfWeek == DayOfWeek.Sunday)) Console.WriteLine("パターン3:今日は日曜日!");
if (isDateTime(dateTime2, (dateTime) => dateTime.DayOfWeek == DayOfWeek.Monday)) Console.WriteLine("パターン3:今日は月曜日!");
if (isDateTime(dateTime, (dateTime) => dateTime.Day != 1 && dateTime.DayOfWeek == DayOfWeek.Sunday)) Console.WriteLine("パターン3:今日は毎月1日以外の日曜日!");

// パターン3　任意の日付判定
bool isDateTime(DateTime dateTime, Func<DateTime, bool> condition)
{
    return condition(dateTime);
}
