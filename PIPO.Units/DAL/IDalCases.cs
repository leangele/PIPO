using System.Collections.Generic;

namespace PIPO.Units.DAL
{
    public interface IDalCases
    {
        List<Case> ListCases();
        void CreateCase(Case objCase);
        Case FindCaseByCode(int nro);
    }
}