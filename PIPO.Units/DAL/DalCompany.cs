using System.Collections.Generic;
using System.Linq;

namespace LabTrack.DAL
{
    class DalCompany : IDalCompany
    {
        private CasesControlEntities Context { get; set; }

        public DalCompany(CasesControlEntities context)
        {
            Context = context;
        }

        public List<Company> ListCompanies()
        {
            return Context.Companies.ToList();

        }

    }
}
