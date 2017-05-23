using System.Collections.Generic;
using LabTrack.DTO;

namespace LabTrack.Interfaces
{
    public interface IDalStoredProcedures
    {
        List<SearchInformationOutDto> ListUnitsPerDay(SearchInformationDto result);
    }
}