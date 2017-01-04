using System;

namespace PIPO.Units.DTO
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
    }
}
