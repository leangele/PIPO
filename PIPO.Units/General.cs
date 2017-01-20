using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LabTrack
{
    public class General
    {
        public static void ValidNumber(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public static List<DateTime> GetHolidays(int year)
        {
            List<DateTime> holidays = new List<DateTime>();
            //NEW YEARS 
            DateTime newYearsDate = AdjustForWeekendHoliday(new DateTime(year, 1, 1).Date);
            holidays.Add(newYearsDate);
            //MEMORIAL DAY  -- last monday in May 
            DateTime memorialDay = new DateTime(year, 5, 31);
            DayOfWeek dayOfWeek = memorialDay.DayOfWeek;
            while (dayOfWeek != DayOfWeek.Monday)
            {
                memorialDay = memorialDay.AddDays(-1);
                dayOfWeek = memorialDay.DayOfWeek;
            }
            holidays.Add(memorialDay.Date);

            //INDEPENCENCE DAY 
            DateTime independenceDay = AdjustForWeekendHoliday(new DateTime(year, 7, 4).Date);
            holidays.Add(independenceDay);

            //LABOR DAY -- 1st Monday in September 
            DateTime laborDay = new DateTime(year, 9, 1);
            dayOfWeek = laborDay.DayOfWeek;
            while (dayOfWeek != DayOfWeek.Monday)
            {
                laborDay = laborDay.AddDays(1);
                dayOfWeek = laborDay.DayOfWeek;
            }
            holidays.Add(laborDay.Date);

            //THANKSGIVING DAY - 4th Thursday in November 
            var thanksgiving = (from day in Enumerable.Range(1, 30)
                                where new DateTime(year, 11, day).DayOfWeek == DayOfWeek.Thursday
                                select day).ElementAt(3);
            DateTime thanksgivingDay = new DateTime(year, 11, thanksgiving);
            holidays.Add(thanksgivingDay.Date);

            DateTime christmasDay = AdjustForWeekendHoliday(new DateTime(year, 12, 25).Date);
            holidays.Add(christmasDay);
            return holidays;
        }


        private static DateTime AdjustForWeekendHoliday(DateTime holiday)
        {
            if (holiday.DayOfWeek == DayOfWeek.Saturday)
            {
                return holiday.AddDays(-1);
            }
            else if (holiday.DayOfWeek == DayOfWeek.Sunday)
            {
                return holiday.AddDays(1);
            }
            else
            {
                return holiday;
            }
        }

        public static int DaysLeft(DateTime startDate, DateTime endDate, Boolean excludeWeekends, List<DateTime> excludeDates)
        {
            int count = 0;
            for (DateTime index = startDate; index < endDate; index = index.AddDays(1))
            {
                if (excludeWeekends && index.DayOfWeek != DayOfWeek.Sunday && index.DayOfWeek != DayOfWeek.Saturday)
                {
                    bool excluded = false; ;
                    for (int i = 0; i < excludeDates.Count; i++)
                    {
                        if (index.Date.CompareTo(excludeDates[i].Date) == 0)
                        {
                            excluded = true;
                            break;
                        }
                    }

                    if (!excluded)
                    {
                        count++;
                    }
                }
            }

            return count;
        }
    }
}