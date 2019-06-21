using System.IO;
using NameSorter.Interface;

namespace NameSorter
{
    class TextFileWriter : IWriter
    {
        private string _filePath;

        public TextFileWriter(string filePath)
        {
            _filePath = filePath;
        }

        public void Write(string[] content)
        {
            File.WriteAllLines(_filePath, content);
        }
    }
}
