using System;

namespace Chapter_6._NET_Fundamentals {
    public class DatesAndTimes {
        public void TimeSpanShow() {
            Console.WriteLine("Демонстрация работы с TimeSpan:\n");
            
            Console.WriteLine("Создание TimeSpan разными способами:");
            Console.WriteLine($"new TimeSpan(2, 30, 00) = {new TimeSpan(2, 30, 00)} (часы, минуты, секунды)");
            Console.WriteLine($"TimeSpan.FromHours(2.5) = {TimeSpan.FromHours(2.5)} (из часов)");
            Console.WriteLine($"TimeSpan.FromHours(-2.5) = {TimeSpan.FromHours(-2.5)} (отрицательный интервал)");
            Console.WriteLine($"TimeSpan.FromHours(2) + TimeSpan.FromMinutes(30) = {TimeSpan.FromHours(2) + TimeSpan.FromMinutes(30)} (сложение)");
            
            Console.WriteLine("\nРабота со свойствами TimeSpan:");
            TimeSpan nearlyTenDays = TimeSpan.FromDays(10) - TimeSpan.FromSeconds(1);
            Console.WriteLine($"TimeSpan nearlyTenDays = TimeSpan.FromDays(10) - TimeSpan.FromSeconds(1) = {nearlyTenDays}");
            Console.WriteLine($"nearlyTenDays.Days = {nearlyTenDays.Days} (целые дни)");
            Console.WriteLine($"nearlyTenDays.Hours = {nearlyTenDays.Hours} (часы в последнем дне)");
            Console.WriteLine($"nearlyTenDays.Minutes = {nearlyTenDays.Minutes} (минуты в последнем часе)");
            Console.WriteLine($"nearlyTenDays.Seconds = {nearlyTenDays.Seconds} (секунды в последней минуте)");
            Console.WriteLine($"nearlyTenDays.Milliseconds = {nearlyTenDays.Milliseconds} (миллисекунды в последней секунде)");
            
            Console.WriteLine("\nОбщие значения (Total*):");
            Console.WriteLine($"nearlyTenDays.TotalDays = {nearlyTenDays.TotalDays} (всего дней)");
            Console.WriteLine($"nearlyTenDays.TotalHours = {nearlyTenDays.TotalHours} (всего часов)");
            Console.WriteLine($"nearlyTenDays.TotalMinutes = {nearlyTenDays.TotalMinutes} (всего минут)");
            Console.WriteLine($"nearlyTenDays.TotalSeconds = {nearlyTenDays.TotalSeconds} (всего секунд)");
            Console.WriteLine($"nearlyTenDays.TotalMilliseconds = {nearlyTenDays.TotalMilliseconds} (всего миллисекунд)");
        }
        
        public void DateTimeShow() {
            Console.WriteLine("\nДемонстрация работы с DateTime:\n");
            
            // Создание объектов DateTime
            Console.WriteLine("Создание объектов DateTime:");
            DateTime now = DateTime.Now;
            Console.WriteLine($"DateTime.Now = {now} (текущие дата и время)");
            DateTime today = DateTime.Today;
            Console.WriteLine($"DateTime.Today = {today} (текущая дата, время 00:00:00)");
            DateTime utcNow = DateTime.UtcNow;
            Console.WriteLine($"DateTime.UtcNow = {utcNow} (текущие дата и время по UTC)");
            
            // Создание конкретной даты
            DateTime specificDate = new DateTime(2023, 12, 31, 23, 59, 59);
            Console.WriteLine($"new DateTime(2023, 12, 31, 23, 59, 59) = {specificDate} (Новый год 2024)");
            
            // Свойства DateTime
            Console.WriteLine("\nСвойства DateTime:");
            Console.WriteLine($"now.Year = {now.Year} (год)");
            Console.WriteLine($"now.Month = {now.Month} (месяц)");
            Console.WriteLine($"now.Day = {now.Day} (день)");
            Console.WriteLine($"now.DayOfWeek = {now.DayOfWeek} (день недели)");
            Console.WriteLine($"now.DayOfYear = {now.DayOfYear} (день года)");
            Console.WriteLine($"now.Hour = {now.Hour} (час)");
            Console.WriteLine($"now.Minute = {now.Minute} (минута)");
            Console.WriteLine($"now.Second = {now.Second} (секунда)");
            Console.WriteLine($"now.Millisecond = {now.Millisecond} (миллисекунда)");
            Console.WriteLine($"now.Kind = {now.Kind} (тип времени: Local, Utc или Unspecified)");
            
            // Операции с датами
            Console.WriteLine("\nОперации с датами:");
            DateTime tomorrow = now.AddDays(1);
            Console.WriteLine($"now.AddDays(1) = {tomorrow} (завтра)");
            DateTime nextMonth = now.AddMonths(1);
            Console.WriteLine($"now.AddMonths(1) = {nextMonth} (следующий месяц)");
            DateTime nextYear = now.AddYears(1);
            Console.WriteLine($"now.AddYears(1) = {nextYear} (следующий год)");
            
            // Разница между датами
            TimeSpan difference = tomorrow - now;
            Console.WriteLine($"tomorrow - now = {difference} (разница между датами)");
            
            // Форматирование дат
            Console.WriteLine("\nФорматирование дат:");
            Console.WriteLine($"now.ToString(\"d\") = {now.ToString("d")} (короткая дата)");
            Console.WriteLine($"now.ToString(\"D\") = {now.ToString("D")} (длинная дата)");
            Console.WriteLine($"now.ToString(\"t\") = {now.ToString("t")} (короткое время)");
            Console.WriteLine($"now.ToString(\"T\") = {now.ToString("T")} (длинное время)");
            Console.WriteLine($"now.ToString(\"f\") = {now.ToString("f")} (полная дата, короткое время)");
            Console.WriteLine($"now.ToString(\"F\") = {now.ToString("F")} (полная дата, длинное время)");
            Console.WriteLine($"now.ToString(\"g\") = {now.ToString("g")} (общая дата, короткое время)");
            Console.WriteLine($"now.ToString(\"G\") = {now.ToString("G")} (общая дата, длинное время)");
            Console.WriteLine($"now.ToString(\"yyyy-MM-dd HH:mm:ss\") = {now.ToString("yyyy-MM-dd HH:mm:ss")} (пользовательский формат)");
        }
        
        public void DateTimeOffsetShow() {
            Console.WriteLine("\nДемонстрация работы с DateTimeOffset:\n");
            
            // Создание объектов DateTimeOffset
            Console.WriteLine("Создание объектов DateTimeOffset:");
            DateTimeOffset now = DateTimeOffset.Now;
            Console.WriteLine($"DateTimeOffset.Now = {now} (текущие дата и время с часовым поясом)");
            DateTimeOffset utcNow = DateTimeOffset.UtcNow;
            Console.WriteLine($"DateTimeOffset.UtcNow = {utcNow} (текущие дата и время по UTC)");
            
            // Создание с указанием смещения
            DateTimeOffset specificWithOffset = new DateTimeOffset(2023, 12, 31, 23, 59, 59, TimeSpan.FromHours(3));
            Console.WriteLine($"DateTimeOffset с UTC+3: {specificWithOffset}");
            
            // Свойства DateTimeOffset
            Console.WriteLine("\nСвойства DateTimeOffset:");
            Console.WriteLine($"now.Offset = {now.Offset} (смещение относительно UTC)");
            Console.WriteLine($"now.DateTime = {now.DateTime} (локальные дата и время)");
            Console.WriteLine($"now.UtcDateTime = {now.UtcDateTime} (UTC дата и время)");
            Console.WriteLine($"now.LocalDateTime = {now.LocalDateTime} (локальные дата и время)");
            
            // Преобразования между часовыми поясами
            Console.WriteLine("\nПреобразования между часовыми поясами:");
            DateTimeOffset inNewYork = TimeZoneInfo.ConvertTime(now, TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time"));
            Console.WriteLine($"Текущее время в Нью-Йорке: {inNewYork}");
        }
    }
}