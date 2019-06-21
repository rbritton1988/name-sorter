using System;
using System.Collections.Generic;
using System.Text;
using NameSorter.Interface;

namespace NameSorter
{
    /// <summary>
    /// Encapsulates a NamesFileManager object which is used to read/write to a given text file.
    /// Providing an additional layer of abstraction to this class's interface.
    /// </summary>
    class NameSorter : AbstractSorter
    {
        private NamesFileManager _namesFileManager;
        private string[] _names;

        public NameSorter(string namesTextFilePath)
        {
            // Initialise the file manager so ts ready to begin work.
            _namesFileManager = new NamesFileManager();
            
            // Read in and store the list of names from given path.
            ReadInNamesTextFile(namesTextFilePath);
        }


        /// <summary>
        /// Overwrite the internal names list with a new list which can produce more results.
        /// </summary>
        /// <param name="filePath">The </param>
        public void ReadInNamesTextFile(string filePath)
        {
            _names = _namesFileManager.ReadIn(filePath);
        }

        /// <summary>
        /// Sort a given list of names into alphabetical order by lastname given.
        /// </summary>
        public void SortByLastName()
        {
            Sort(_names);
            _names = ReverseValues(_names);
            Sort(_names);
        }
    }
}
