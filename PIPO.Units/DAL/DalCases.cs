using LabTrack.DTO;
using LabTrack.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace LabTrack.DAL
{
    public class DalCases : IDalCases
    {
        private readonly CasesControlEntities _context;

        public DalCases(CasesControlEntities context)
        {
            _context = context;
        }

        public List<Case> ListCases()
        {
            return _context.Cases.ToList();
        }

        public void CreateCase(Case objCase)
        {
            _context.Cases.Add(objCase);
        }

        public Case FindCaseByCode(int nro)
        {
            return _context.Cases.FirstOrDefault(x => x.Code == nro);
        }

        public List<Case> FindCasesByRange(IEnumerable<CaseControlDto> closedThisWeek)
        {
            var nroCases = (from item in closedThisWeek where item.Code != null select (int)item.Code).ToList();
            return _context.Cases.Where(x => nroCases.Contains(x.Code)).ToList();
        }
    }
}
