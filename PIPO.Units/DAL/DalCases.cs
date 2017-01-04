using System.Collections.Generic;
using System.Linq;

namespace PIPO.Units.DAL
{
    public class DalCases : IDalCases
    {
        private CasesControlEntities _context;

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
    }
}
