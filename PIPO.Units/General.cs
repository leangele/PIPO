using LabTrack.DAL;
using LabTrack.DTO;
using LabTrack.Forms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace LabTrack
{
    public class General
    {
        public static void ValidNumber(KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public static void ShowHistoryOfCase(UnitOfWork unitOfWork, bool isAdministrationOn)
        {
            var dataCases = new DataCases(unitOfWork, isAdministrationOn);
            dataCases.ShowDialog();
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

        public static CaseControl CreateCaseControl(UnitOfWork unitOfWork, int nro, CaseControl data, DateTime today, Area areaConsult)
        {
            if (data != null)
            {
                return new CaseControl();
            }
            else
            {
                data = new CaseControl { code = nro, dtRecive = today, idTechnitian = areaConsult.Id };
                if ((areaConsult.IsEnd || areaConsult.IsStart))
                {
                    data.dtFinish = today;
                    data.dtStart = today;
                    data.dtRecive = today;
                }
                unitOfWork.DalCasesControl.CreateCaseControl(data);
                return data;
            }
        }

        private static bool CreateFileAndFolder(FileLog fileLog)
        {
            //= "Logs";
            //file.FolderName = @"c:\LabTrack";
            var pathString = Path.Combine(fileLog.FolderName, fileLog.SubFolder);
            if (!Directory.Exists(fileLog.FolderName))
            {
                Directory.CreateDirectory(fileLog.FolderName);
            }

            if (!Directory.Exists(pathString))
            {
                Directory.CreateDirectory(pathString);
            }
            //var fileName = "LogError.txt";
            pathString = Path.Combine(pathString, fileLog.FileName);
            if (!File.Exists(pathString))
            {
                using (var fs = File.Create(pathString))
                {
                    for (byte i = 0; i < 100; i++)
                    {
                        fs.WriteByte(i);
                    }
                }
                return true;
            }
            else
            {
                return true;
            }
        }

        public List<string> ReadLog(FileLog fileLog)
        {
            if (!CreateFileAndFolder(fileLog)) return new List<string>();
            var pathString = Path.Combine(fileLog.FolderName, fileLog.SubFolder, fileLog.FileName);
            var list = new List<string>();
            try
            {
                using (var reader = new StreamReader(pathString))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        list.Add(line); // Add to list.
                        Console.WriteLine(line); // Write to console.
                    }
                }
                return list;

            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public static void WriteLog(FileLog fileLog)
        {
            var pathString = Path.Combine(fileLog.FolderName, fileLog.SubFolder, fileLog.FileName);
            if (!CreateFileAndFolder(fileLog)) return;
            using (var file = new StreamWriter(pathString, true))
            {
                var logLine = $"{DateTime.Now:G}: {fileLog.Text}.";

                file.WriteLine(logLine);
            }
        }

        public static FileLog CreateFileLog()
        {
            return new FileLog(@"c:\LabTrack", "Logs", "LogError.txt");
        }

        public static void ControlErrorEx(Exception ex)
        {
            var filelog = General.CreateFileLog();
            filelog.Text =
                $"{ex.GetType().FullName}\r\n{ex.Message}\r\n-------------------------------------------------------------\r\n\r\n";
            General.WriteLog(filelog);
        }
    }
}