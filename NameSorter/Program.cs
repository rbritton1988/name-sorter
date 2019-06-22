using System;

namespace NameSorter
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                throw new Exception("Missing Argument: the path to a file containing names is required.");
            }

            string inputFilePath = args[0];
            const string outputFilePath = "./sorted-names-list.txt";

            string[] names = TextFileReader.Read(inputFilePath);

            NameSorter nameSorter = new NameSorter();
            nameSorter.SortByLastName(names);
            nameSorter.DisplayNames(names);
            nameSorter.WriteNamesToFile(names, outputFilePath);
        
        }
    }
}
