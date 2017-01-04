using PIPO.Units.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace PIPO.Units.DAL
{
    public class DalAreas : IDalAreas
    {
        private readonly CasesControlEntities _context;

        public DalAreas(CasesControlEntities context)
        {
            _context = context;
        }
        public List<Area> ListAreas()
        {
            return _context.Areas.ToList();
        }
    }
}
