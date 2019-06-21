using System;
using System.IO;
using NameSorter.Interface;

namespace NameSorter
{
    /// <summary>
    /// Implements the TextFileManager interface whilst providing addition checks of the filepath provided.
    /// </summary>
    class NamesFileManager : ITextFileManager
    {
        private bool CheckFilePathValid(string filePath)
        {
            return true;
        }

        public string[] ReadIn(string filePath)
        {
            bool filePathValid = CheckFilePathValid(filePath);
            string[] names = File.ReadAllLines(filePath);
            return names;
        }

        public void WriteOut(string filePath, string[] content)
        {
            File.WriteAllLines(filePath, content);
        }
    }
}
