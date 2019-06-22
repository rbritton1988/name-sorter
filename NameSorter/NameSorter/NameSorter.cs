using NameSorter.Interface;

namespace NameSorter
{
    /// <summary>
    /// Encapsulates a NamesFileManager object which is used to read/write to a given text file.
    /// Providing an additional layer of abstraction to this class's interface.
    /// </summary>
    public class NameSorter : Sorter
    {
        private IWriter _writer;


        /// <summary>
        /// Sort a given list of names into alphabetical order by lastname given.
        /// </summary>
        public string[] SortByLastName(string[] names)
        {
            names = ReverseValues(names);
            Sort(names);
            names = ReverseValues(names);
            return names;
        }


        /// <summary>
        /// Writes the content of the internal _names array to the standard output.
        /// </summary>
        public void DisplayNames(string[] names)
        {
            // Substitute the _writer interface with a concrete ConsoleWriter and invokes it's Write method.
            _writer = new ConsoleWriter();
            _writer.Write(names);
        }


        /// <summary>
        /// Write/Overwrites the content of the internal _names array to a given file.
        /// Creates the file if it doesn't exist.
        /// </summary>
        /// <param name="outputFilePath">The path to the text file to write/overwrite.</param>
        public void WriteNamesToFile(string[] names, string outputFilePath)
        {
            // Substitute the _writer interface with a concrete FileWriter and invokes it's Write method.
            _writer = new TextFileWriter(outputFilePath);
            _writer.Write(names);
        }
    }
}
