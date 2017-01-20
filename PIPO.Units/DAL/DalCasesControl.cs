using LabTrack.DTO;
using LabTrack.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LabTrack.DAL
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
                CaseControls.Join(_context.Areas, cc => cc.idTechnitian, x => x.Id, (cc, x) => new { cc, x }).
                Select(y => new CaseControlDto
                {
                    Id = y.cc.Id,
                    IdArea = y.cc.idTechnitian,
                    Area = y.x.Name,
                    Incharge = y.x.NamePerson,
                    Code = y.cc.code,
                    DtFinish = y.cc.dtFinish,
                    DtRecive = y.cc.dtRecive,
                    DtStart = y.cc.dtStart
                }).
                ToList();
            return listCases;
        }

        public CaseControl GetCaseById(int idCaseContro)
        {
            return _context.CaseControls.SingleOrDefault(x => x.Id == idCaseContro);
        }

        public List<CaseControlDto> ListCasesByCode(int code)
        {
            var listCases = _context.CaseControls
              .Where(x => x.code == code)
              .OrderBy(y => y.idTechnitian)
              .Join(_context.Areas, cc => cc.idTechnitian, x => x.Id, (cc, x) => new { cc, x })
              .Select(y => new CaseControlDto
              {
                  Id = y.cc.Id,
                  IdArea = y.cc.idTechnitian,
                  Area = y.x.Name,
                  Incharge = y.x.NamePerson,
                  Code = y.cc.code,
                  DtFinish = y.cc.dtFinish,
                  DtRecive = y.cc.dtRecive,
                  DtStart = y.cc.dtStart
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
