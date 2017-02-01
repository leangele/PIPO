using LabTrack.DTO;
using LabTrack.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace LabTrack.DAL
{
    public class DalCasesControl : IDalCasesControl
    {
        private readonly CasesControlEntities _context;

        public DalCasesControl(CasesControlEntities context)
        {
            _context = context;
        }

        public List<CaseControlDto> ListCases()
        {
            var listCases = CaseControlDtos();
            return listCases;
        }



        public CaseControl GetCaseById(int idCaseContro)
        {
            return _context.CaseControls.SingleOrDefault(x => x.Id == idCaseContro);
        }

        public List<CaseControlDto> ListCasesByCode(int code)
        {
            var listCases = CaseControlDtos().Where(x => x.Code == code).ToList();
            return listCases;
        }

        public void CreateCaseControl(CaseControl caseControl)
        {

            _context.CaseControls.Add(caseControl);
        }


        public CaseControl GetCaseControlByIdAreaAndCode(int nro, int idArea)
        {


            return _context.CaseControls.SingleOrDefault(x => x.code == nro && x.idTechnitian == idArea);
        }
        public List<CaseControlDto> GetCaseControlsByIdArea(int idArea)
        {


            return CaseControlDtos().Where(x => x.IdArea == idArea).ToList();
        }

        public void ModifyByClose(CaseControl caseControl)
        {
            var date = caseControl.dtFinish;
            caseControl =
                _context.CaseControls.SingleOrDefault(
                    x => x.code == caseControl.code && x.idTechnitian == caseControl.idTechnitian);
            if (caseControl == null) return;
            caseControl.dtFinish = date;
            caseControl.dtStart = caseControl.dtStart.HasValue ? caseControl.dtStart : date;
            caseControl.isClosedByAdmin = true;
        }

        private List<CaseControlDto> CaseControlDtos()
        {
            var listCases = _context
                .CaseControls
                .Join(_context.Areas, cc => cc.idTechnitian, a => a.Id, (cc, a) => new { cc, a })
                .Join(_context.Cases, c => c.cc.code, x => x.Code, (c, x) => new { c, x })
                .Join(_context.Companies, com => com.x.IdCompany, p => p.Id, (com, x) => new { com, x })
                .Select(y => new CaseControlDto
                {
                    Id = y.com.c.cc.Id,
                    IdArea = y.com.c.cc.idTechnitian,
                    Area = y.com.c.a.Name,
                    Incharge = y.com.c.a.NamePerson,
                    Code = y.com.c.cc.code,
                    DtFinish = y.com.c.cc.dtFinish,
                    DtRecive = y.com.c.cc.dtRecive,
                    DtStart = y.com.c.cc.dtStart,
                    Unit = y.com.x.Units,
                    Company = y.x.Name
                }).
                ToList();
            return listCases;
        }
    }
}
