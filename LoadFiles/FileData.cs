using System.IO;

namespace LoadFiles
{
    internal class FileData
    {       
        public string FullPath { get; set; }
        public string FileContent { get; set; }

        public FileData(string fullPath, string fileContent)
        {
            FullPath = fullPath;
            FileContent = fileContent;
        }

        public override string ToString()
        {
            return Path.GetFileNameWithoutExtension(FullPath);
        }
    }
}
