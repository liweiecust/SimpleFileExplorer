using System.IO;

namespace SimpleFileExplorer.Models
{
    public class FileInformation
    {
        public FileInformation(string filepath)
        {
            FileName = filepath;
            FileType = Directory.Exists(filepath) ? FileType.Folder : FileType.File;  //有文件 就赋值为folder
        }
        public FileInformation()
        {

        }
       
   

        public string FileName { get; set; }

        public FileType FileType { get; set; }
    }
}
