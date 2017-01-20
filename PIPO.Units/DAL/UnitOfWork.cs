using LabTrack.Interfaces;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace LabTrack.DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        private static CasesControlEntities _context;
        public IDalAreas DalAreas { get; set; }
        public IDalCasesControl DalCasesControl { get; set; }
        public IDalCases DalCases { get; set; }
        public IDalConfig DalConfig { get; set; }
        public IDalStoredProcedures DalStoredProcedures { get; set; }



        public UnitOfWork(CasesControlEntities context)
        {
            _context = context;

            DalAreas = new DalAreas(_context);
            DalCasesControl = new DalCasesControl(_context);
            DalCases = new DalCases(_context);
            DalConfig = new DalConfig(_context);
            DalStoredProcedures = new DalStoredProcedures(_context);
        }

        public void SaveData()
        {
            _context.SaveChanges();
        }

        public List<Configuration> ListConfigurations()
        {
            return DalConfig.ListConfigurations();
        }

        public bool CheckConection(CasesControlEntities _context)
        {
            try
            {
                return _context.Database.Exists();
            }
            catch (SqlException ex)
            {

                return false;
            }
        }
    }
}
