using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotePadMinusMinus.Services
{
    public class FileService
    {
        public string Open(string path)
        {
            string filePath = path;
            return File.ReadAllText(filePath);
        }

        public void Save(string path, string content)
        {
            File.WriteAllText(path, content);
        }

        public string GetTextLength(string text)
        {
            return text.Length.ToString();
        }
    }
}
