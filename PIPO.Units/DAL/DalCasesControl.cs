using PIPO.Units.DTO;
using PIPO.Units.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PIPO.Units.DAL
{
    public class DalCasesControl : IDalCasesControl
    {
        private CasesControlEntities _context;

        public DalCasesControl(CasesControlEntities context)
        {
            _context = context;
        }

        public List<CaseControlDto> ListCases()
        {
            var listCases = _context.
                CaseControls.
                Select(
                    y => new CaseControlDto
                    {
                        Id = y.Id,
                        IdArea = y.idTechnitian,
                        Area = y.Technitian.name,
                        Code = y.code,
                        DtFinish = y.dtFinish,
                        DtRecive = y.dtRecive,
                        DtStart = y.dtStart
                    }).
                ToList();
            return listCases;
        }

        public void CreateCaseControl(int nro, int idArea)
        {
            _context.CaseControls.Add(new CaseControl { code = nro, dtRecive = DateTime.Now, idTechnitian = idArea });
        }


        public CaseControl GetCaseControlByIdAreaAndCode(int nro, int idArea)
        {
            return _context.CaseControls.SingleOrDefault(x => x.code == nro && x.idTechnitian == idArea);
        }
    }
}
