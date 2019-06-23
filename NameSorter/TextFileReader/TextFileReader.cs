using System.IO;

namespace NameSorter
{
    static class TextFileReader
    {
        /// <summary>
        /// A simple helper method for reading all lines within a text file.
        /// </summary>
        /// <param name="filePath">The path to the text file to read.</param>
        /// <returns>An array of strings, representing all the lines within the text file.</returns>
        public static string[] Read(string filePath)
        {
            string[] names = File.ReadAllLines(filePath);
            return names;
        }
    }
}
