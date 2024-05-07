using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PGENV3
{
    internal class GetPathOrExtention
    {
        public string GetFileExtension(string fileName)
        {
            string extension;
            extension = Path.GetExtension(fileName);
            return extension;
        }

        public string GetDirPath(string fileName)
        {
            string directoryPath = Path.GetDirectoryName(fileName);
            return directoryPath;
        }

        public string GetfileName(string fileName)
        {
            string filename = Path.GetFileName(fileName);
            return filename;
        }
    }
}
