using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoadFiles
{
    internal class FileData
    {
        public string FileName { get; set; }
        public string FileContent { get; set; }

        public FileData(string fileName, string fileContent)
        {
            FileName = fileName;
            FileContent = fileContent;
        }
    }
}
