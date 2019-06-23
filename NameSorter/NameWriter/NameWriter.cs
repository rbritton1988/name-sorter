using NameSorter.Interface;
using NameSorter.Writer;

namespace NameSorter
{
    /// <summary>
    /// Provides methods for writing names to the console or a file.
    /// </summary>
    public static class NameWriter
    {
        // The writer switches between ConsoleWriter and TextFileWriter depending on which method is called.
        private static IWriter _writer;

        /// <summary>
        /// Writes the content of the given names array to the standard output.
        /// </summary>
        /// <param name="names">The names to display on console.</param>
        public static void WriteNamesToConsole(string[] names)
        {
            // Substitute the _writer interface with a concrete ConsoleWriter and invokes it's Write method.
          _writer = new ConsoleWriter();
          _writer.Write(names);
        }


        /// <summary>
        /// Write/Overwrites the content of the given names array to a .txt file named with the given outputFileName.
        /// The file is created/overwritten in the applications cwd.
        /// </summary>
        /// <param name="outputFileName">The name of the .txt file to write/overwrite.</param>
        public static void WriteNamesToFile(string[] names, string outputFileName)
        {
            // Substitute the _writer interface with a concrete TextFileWriter and invokes it's Write method.
            _writer = new TextFileWriter(outputFileName);
            _writer.Write(names);
        }
    }
}
