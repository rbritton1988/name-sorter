using System;
using NameSorter;

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
            LastNameSorter nameSorter = new LastNameSorter();
            names = nameSorter.Sort(names);

            // Display and Write the names.
            NameWriter.WriteNamesToConsole(names);
            NameWriter.WriteNamesToFile(names, OutputFileName);
        }
    }
}
