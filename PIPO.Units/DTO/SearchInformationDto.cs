using System;

namespace LabTrack.DTO
{
    public class SearchInformationDto
    {
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public string Filter { get; set; }
    }
}
