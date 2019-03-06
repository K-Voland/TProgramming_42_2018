using System;

namespace CourseApp
{
    public class Date
    {
        public static string DateB(DateTime dr)
        {
            return DateTime.Today.AddYears(-dr.Year).AddMonths(-dr.Month).AddDays(-dr.Day).ToString("Год: yy Месяц: MM День: dd");
        }
    }
}