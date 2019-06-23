using System;
using NameSorter.Interface;

namespace NameSorter.Writer
{
    /// <summary>
    /// Provides a method for writing lines of text to the console.
    /// </summary>
    public class ConsoleWriter : IWriter
    {
        /// <summary>
        /// Write an array of strings to the console line by line.
        /// </summary>
        /// <param name="text">The string array to write to the console</param>
        public void Write(string[] text)
        {
            foreach (string line in text)
            {
                Console.WriteLine(line);
            }
        }
    }
}
