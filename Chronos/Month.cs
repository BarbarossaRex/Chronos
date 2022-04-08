using System;
using System.Collections.Generic;

namespace Chronos
{
    internal class Month
    {
        public List<Day> Days = new List<Day>();
        public string MonthName { get; set; }

        public Month(int year, string monthName)
        {
            MonthName = monthName;
            CreateDaysOfMonth(year, monthName);
        }

        private void CreateDaysOfMonth(int year, string monthName)
        {
            int month = 0;

            if (monthName == "Januar") { month = 1; }
            else if (monthName == "Februar") { month = 2; }
            else if (monthName == "März") { month = 3; }
            else if (monthName == "April") { month = 4; }
            else if (monthName == "Mai") { month = 5; }
            else if (monthName == "Juni") { month = 6; }
            else if (monthName == "Juli") { month = 7; }
            else if (monthName == "August") { month = 8; }
            else if (monthName == "September") { month = 9; }
            else if (monthName == "Oktober") { month = 10; }
            else if (monthName == "November") { month = 11; }
            else if (monthName == "Dezember") { month = 12; }
            else {}

            int daysInMonth = DateTime.DaysInMonth(year, month);

            for(int i = 1; i <= daysInMonth; i++)
            {
                Day newDay = new Day();
                newDay.DayDate = new DateTime(year, month, i).ToString("dd.MM.yyyy");
                newDay.DayName = GetDayOfWeek(new DateTime(year, month, i));
                Days.Add(newDay);
            }
        }

        private string GetDayOfWeek(DateTime date)
        {
            string dateName = "ERROR";
            int dayNumber = (int)date.DayOfWeek;
            if(dayNumber == 1){ dateName = "Montag"; }
            else if(dayNumber == 2){ dateName = "Dienstag"; }
            else if (dayNumber == 3) { dateName = "Mittwoch"; }
            else if (dayNumber == 4) { dateName = "Donnerstag"; }
            else if (dayNumber == 5) { dateName = "Freitag"; }
            else if (dayNumber == 6) { dateName = "Samstag"; }
            else if (dayNumber == 0) { dateName = "Sonntag"; }
            else { dateName = "ERROR2"; }

            return dateName;
        }
    }
}