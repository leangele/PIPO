using PIPO.Units.Interfaces;

namespace PIPO.Units.DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        private static CasesControlEntities _context;
        public IDalAreas DalAreas { get; set; }
        public IDalCasesControl DalCasesControl { get; set; }

        public IDalCases DalCases { get; set; }



        public UnitOfWork(CasesControlEntities context)
        {

            _context = context;
            DalAreas = new DalAreas(_context);
            DalCasesControl = new DalCasesControl(_context);
            DalCases = new DalCases(_context);
        }

        public void SaveData()
        {
            _context.SaveChanges();
        }
    }
}
