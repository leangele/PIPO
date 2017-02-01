using LabTrack.DTO;
using System.Collections.Generic;

namespace LabTrack.Interfaces
{
    public interface IDalCasesControl
    {
        void CreateCaseControl(CaseControl caseControl);
        CaseControl GetCaseControlByIdAreaAndCode(int nro, int idArea);
        List<CaseControlDto> ListCases();

        CaseControl GetCaseById(int idCaseContro);
        List<CaseControlDto> ListCasesByCode(int code);
        List<CaseControlDto> GetCaseControlsByIdArea(int idArea);
        void ModifyByClose(CaseControl caseControl);
    }
}