using System;
using NameSorter.Writer;

namespace NameSorter
{
    class Program
    {
        static void Main(string[] args)
        {
            const string OutputFileName = "sorted-names-list";

            // Throw if no args are passed in.
            if (args.Length == 0)
            {  
                throw new Exception("Missing Argument: the path to a file containing names is required.");
            }

            // Get the filePath from first arg then read its text.
            string inputFilePath = args[0];
            string[] names = TextFileReader.Read(inputFilePath);

            // Create an instance of the NameSorter and sort the names.
            NameSorter nameSorter = new NameSorter();
            names = nameSorter.SortByLastName(names);

            // Display and Write the names.
            NameWriter.WriteNamesToConsole(names);
            NameWriter.WriteNamesToFile(names, OutputFileName);
        }
    }
}
