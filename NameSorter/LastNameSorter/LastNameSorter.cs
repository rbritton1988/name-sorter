using System;

namespace NameSorter
{
    /// <summary>
    /// A concrete class that ihenrits from the AbstractNameSorter to provide Sort method.
    /// </summary>
    public class LastNameSorter : AbstractNameSorter
    {
        // A name reverser component provides methods useful for when sorting by last name;
        private readonly NameReverser _nameReverser;

        public LastNameSorter()
        {
            _nameReverser = new NameReverser();
        }

        /// <summary>
        /// Sort a given array of names in alphabetical order by lastname.
        /// </summary>
        /// <param name="names">The array of names to sort.</param>
        /// <returns></returns>
        public override string[] Sort(string[] names)
        {
            if (names.Length == 0)
            {
                throw new Exception("names should not be empty");
            }

            // Switch the order of each name from (firstname -> lastname) to (lastname -> firstname).
            names = _nameReverser.ReverseEachName(names);
            // Sort list of reversed names (which sorts by lastname due to names being reversed)
            Array.Sort(names);
            // Switch the order of each name from (lastname -> firstname) to (firstname -> lastname).
            return _nameReverser.ReverseEachName(names);
        }
    }
}
