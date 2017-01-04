using PIPO.Units.DTO;
using System.Collections.Generic;

namespace PIPO.Units.Interfaces
{
    public interface IDalCasesControl
    {
        void CreateCaseControl(int nro, int idArea);
        CaseControl GetCaseControlByIdAreaAndCode(int nro, int idArea);
        List<CaseControlDto> ListCases();

    }
}