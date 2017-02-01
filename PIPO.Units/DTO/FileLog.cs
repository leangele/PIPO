namespace LabTrack.DTO
{
    public class FileLog
    {
        private readonly string _fileName;
        public string FolderName { get; set; }
        public string SubFolder { get; set; }
        public string FileName { get; set; }
        public string Text { get; set; }

        public FileLog(string folderName, string subFolder, string fileName)
        {
            _fileName = fileName;
            FolderName = folderName;
            SubFolder = subFolder;
        }
    }
}
