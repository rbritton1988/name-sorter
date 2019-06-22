using System;
using NameSorter.Interface;

namespace NameSorter.Writer
{
    /// <summary>
    /// A simple helper class for writing multiple lines of text to the standard output.
    /// </summary>
    public class ConsoleWriter : IWriter
    {
        public void Write(string[] text)
        {
            foreach (string line in text)
            {
                Console.WriteLine(line);
            }
        }
    }
}
