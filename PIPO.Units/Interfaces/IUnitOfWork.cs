using PIPO.Units.DAL;

namespace PIPO.Units.Interfaces
{
    public interface IUnitOfWork
    {
        IDalAreas DalAreas { get; }
        IDalCasesControl DalCasesControl { get; }
        IDalCases DalCases { get; }
        void SaveData();
    }
}