using System;
using NameSorter.Interface;
using NameSorter.Writer;

namespace NameSorter
{
    /// <summary>
    /// Provides a method for sorting a list of names in alphabetical order by lastname.
    /// Provides additional methods for displaying names to the console and writing names to a file.
    /// </summary>
    public class NameSorter
    {
        // The writer switches between ConsoleWriter and TextFileWriter depending on which method is called.
        private IWriter _writer;

        /// <summary>
        /// Reverse the order of each fullname within the given array of names.
        /// </summary>
        /// <param name="names">The array of names to reverse</param>
        /// <returns>The given array of names with each name in reverse order</returns>
        private string[] ReverseEachName(string[] names)
        {
            // Get the length of the array, so it isn't calculated on each pass of the for loop.
            int namesCount = names.Length;

            // Create an empty array of the same length as given value array.
            string[] reversedNames = new string[namesCount];

            // On each pass, split the fullname into single names
            // Reverse the order of the names and join back into fullname, putting the space back.
            // Store each reversed fullname in the reversedNames array.
            for (int index = 0; index < namesCount; index++)
            {
                string[] splitFullName = names[index].Split(' ');
                Array.Reverse(splitFullName);
                reversedNames[index] = string.Join(" ", splitFullName);
            }

            // Return the populated array of reveresed names.
            return reversedNames;
        }


        /// <summary>
        /// Sort the given array of names in alphabetical order.
        /// </summary>
        /// <param name="names">The array of names to sort</param>
        private void Sort(string[] names)
        {
            Array.Sort(names);
        }


        /// <summary>
        /// Sort a given array of names in alphabetical order by lastname.
        /// </summary>
        /// <param name="names">The array of names to sort.</param>
        /// <returns></returns>
        public string[] SortByLastName(string[] names)
        {
            if(names.Length == 0)
            {
                throw new Exception("names should not be empty");
            }

            // Switch the order of each name from (firstname -> lastname) to (lastname -> firstname).
            names = ReverseEachName(names);
            // Sort list of reversed names (which sorts by lastname due to names being reversed)
            Sort(names);
            // Switch the order of each name from (lastname -> firstname) to (firstname -> lastname).

            return ReverseEachName(names);
        }


        /// <summary>
        /// Writes the content of the given names array to the standard output.
        /// </summary>
        /// <param name="names">The names to display on console.</param>
        public void DisplayNames(string[] names)
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
        public void WriteNamesToFile(string[] names, string outputFileName)
        {
            // Substitute the _writer interface with a concrete TextFileWriter and invokes it's Write method.
            _writer = new TextFileWriter(outputFileName);
            _writer.Write(names);
        }
    }
}
