using LabTrack.DTO;
using System.Collections.Generic;

namespace LabTrack.Interfaces
{
    public interface IDalCasesControl
    {
        void CreateCaseControl(int nro, int idArea);
        CaseControl GetCaseControlByIdAreaAndCode(int nro, int idArea);
        List<CaseControlDto> ListCases();

        CaseControl GetCaseById(int idCaseContro);
        List<CaseControlDto> ListCasesByCode(int code);
    }
}