using NameSorter.Interface;

namespace NameSorter
{
    /// <summary>
    /// Encapsulates a NamesFileManager object which is used to read/write to a given text file.
    /// Providing an additional layer of abstraction to this class's interface.
    /// </summary>
    class NameSorter : Sorter
    {
        private string[] _names;
        private IWriter _writer;
        
        public NameSorter(string inputFilePath)
        {
            // Read in and store the list of names from given path.
            _names = TextFileReader.Read(inputFilePath);
        }


        /// <summary>
        /// Sort a given list of names into alphabetical order by lastname given.
        /// </summary>
        public void SortByLastName()
        {
            _names = ReverseValues(_names);
            Sort(_names);
            _names = ReverseValues(_names);
        }


        /// <summary>
        /// Writes the content of the internal _names array to the standard output.
        /// </summary>
        public void DisplayNames()
        {
            // Substitute the _writer interface with a concrete ConsoleWriter and invokes it's Write method.
            _writer = new ConsoleWriter();
            _writer.Write(_names);
        }


        /// <summary>
        /// Write/Overwrites the content of the internal _names array to a given file.
        /// Creates the file if it doesn't exist.
        /// </summary>
        /// <param name="outputFilePath">The path to the text file to write/overwrite.</param>
        public void WriteNamesToFile(string outputFilePath)
        {
            // Substitute the _writer interface with a concrete FileWriter and invokes it's Write method.
            _writer = new TextFileWriter(outputFilePath);
            _writer.Write(_names);
        }
    }
}
