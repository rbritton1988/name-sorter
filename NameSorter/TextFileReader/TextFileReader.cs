using System.IO;

namespace NameSorter
{
    static class TextFileReader
    {
        public static string[] Read(string filePath)
        {
            string[] names = File.ReadAllLines(filePath);
            return names;
        }
    }
}
