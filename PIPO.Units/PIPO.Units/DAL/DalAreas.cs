using LabTrack.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace LabTrack.DAL
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

        public Area GetAreaForId(int idArea)
        {
            return _context.Areas.SingleOrDefault(x => x.Id == idArea);
        }
    }
}
