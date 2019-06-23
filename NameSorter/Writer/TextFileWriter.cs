using System;
using System.IO;
using NameSorter.Interface;

namespace NameSorter.Writer
{
    /// <summary>
    /// Provides a method for Writes/Overwriting text in a named .txt file within the CWD.
    /// </summary>
    public class TextFileWriter : IWriter
    {
        private string _filePath;

        /// <summary>
        /// Accepts the name of the .txt file to write content to.
        /// </summary>
        /// <param name="fileName">The name of the .txt file</param>
        public TextFileWriter(string fileName)
        {
            if (string.IsNullOrWhiteSpace(fileName))
            {
                throw new Exception("file name should not be empty");
            }
            // Get the cwd and form a path using the given fileName and appending .txt
            // Store the file path for future writing.
            string currentWorkingDir = Directory.GetCurrentDirectory();
            _filePath = Path.Combine(currentWorkingDir, fileName + ".txt");
        }

        /// <summary>
        /// Write the given text to the .txt file specified at construction.
        /// </summary>
        /// <param name="text">The text to write to the .txt file</param>
        public void Write(string[] text)
        {
            File.WriteAllLines(_filePath, text);
        }

    }
}
