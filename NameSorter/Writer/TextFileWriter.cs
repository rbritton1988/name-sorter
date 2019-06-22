using System.IO;
using System;
using NameSorter.Interface;

namespace NameSorter
{
    public class TextFileWriter : IWriter
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
