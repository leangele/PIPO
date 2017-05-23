using System.Collections.Generic;

namespace LabTrack.Interfaces
{
    public interface IDalAreas
    {
        List<Area> ListAreas();
        Area GetAreaForId(int idArea);
    }
}