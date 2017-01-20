using LabTrack.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using LabTrack.Interfaces;

namespace LabTrack.DAL
{
    public class DalStoredProcedures : IDalStoredProcedures
    {
        private CasesControlEntities _context;

        public DalStoredProcedures(CasesControlEntities context)
        {
            _context = context;
        }

        public List<SearchInformationOutDto> ListUnitsPerDay(SearchInformationDto result)
        {

            var dateIni = DateTime.Parse(result.DateStart.ToString("dd-MMM-yyyy"));
            var dateEnd = DateTime.Parse(result.DateEnd.ToString("dd-MMM-yyyy"));
            var sp =
                 _context
                 .Database
                 .SqlQuery<SearchInformationOutDto>("SearchInformation @DateStart, @DateEnd, @filter",
                     new SqlParameter("@DateStart", dateIni.Date),
                     new SqlParameter("@DateEnd", dateEnd.Date),
                     new SqlParameter("@filter", result.Filter))
                 .ToList();
            return sp;
        }
    }
}
