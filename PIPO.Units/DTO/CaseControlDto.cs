using System;

namespace LabTrack.DTO
{
    public class CaseControlDto
    {
        public int Id { get; set; }
        public int? Code { get; set; }
        public DateTime? DtRecive { get; set; }
        public DateTime? DtStart { get; set; }
        public DateTime? DtFinish { get; set; }
        public string Area { get; set; }
        public int IdArea { get; set; }
        public string Incharge { get; set; }

        //public double TimeAverage
        //{
        //    get { return TimeAverage; }
        //    set
        //    {
        //        if (DtFinish != null && DtStart != null)
        //            TimeAverage = ((DateTime)DtFinish).Subtract(((DateTime)DtStart)).TotalMinutes;
        //        TimeAverage = value;
        //    }
        //}
    }
}
