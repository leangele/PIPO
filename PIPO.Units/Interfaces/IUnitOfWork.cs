using LabTrack.DAL;
using System.Collections.Generic;

namespace LabTrack.Interfaces
{
    public interface IUnitOfWork
    {
        IDalAreas DalAreas { get; }
        IDalCasesControl DalCasesControl { get; }
        IDalCases DalCases { get; }

        IDalStoredProcedures DalStoredProcedures { get; }
        void SaveData();
        List<Configuration> ListConfigurations();
    }
}