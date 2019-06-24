using System;

namespace NameSorter
{
    /// <summary>
    /// A class that provides methods for reversing names.
    /// </summary>
    public class NameReverser
    {
        /// <summary>
        /// Reverse the order of each fullname within the given array of names.
        /// </summary>
        /// <param name="names">The array of names to reverse</param>
        /// <returns>The given array of names with each name in reverse order</returns>
        public string[] ReverseEachName(string[] names)
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
                reversedNames[index] = ReverseNameOrder(names[index]);
            }

            // Return the populated array of reveresed names.
            return reversedNames;
        }


        /// <summary>
        /// Reverse the order of a name (firstname -> lastname) becomes (lastname -> firstname).
        /// </summary>
        /// <param name="name">The name to reverse the order</param>
        /// <returns></returns>
        public string ReverseNameOrder(string name)
        {
            string[] splitName = name.Split(' ');
            Array.Reverse(splitName);
            return string.Join(" ", splitName);
        }
    }
}
