using System.Collections.Generic;
using LabTrack.DTO;

namespace LabTrack.Interfaces
{
    public interface IDalCases
    {
        List<Case> ListCases();
        void CreateCase(Case objCase);
        Case FindCaseByCode(int nro);
        List<Case> FindCasesByRange(IEnumerable<CaseControlDto> closedThisWeek);
    }
}