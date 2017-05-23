using System.Collections.Generic;
using System.Linq;
using LabTrack.Interfaces;

namespace LabTrack.DAL
{
    public class DalConfig : IDalConfig
    {

        private readonly CasesControlEntities _context;

        public DalConfig(CasesControlEntities context)
        {
            _context = context;
        }

        public List<Configuration> ListConfigurations()
        {
            var x = _context.Configurations.ToList();
            return x;
        }
    }
}
