namespace LabTrack.DTO
{
    public class FileLog
    {
        public string FolderName { get; set; }
        public string SubFolder { get; set; }
        public string FileName { get; set; }
        public string FormName { get; set; }
        public string Text { get; set; }

        public FileLog(string folderName, string subFolder, string fileName, string formName)
        {
            FileName = fileName;
            FormName = formName;
            FolderName = folderName;
            SubFolder = subFolder;
        }
    }
}
