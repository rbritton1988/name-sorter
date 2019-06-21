using System;
using NameSorter.Interface;

namespace NameSorter
{
    /// <summary>
    /// A simple helper class for writing multiple lines of text to the standard output.
    /// </summary>
    class ConsoleWriter : IWriter
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
