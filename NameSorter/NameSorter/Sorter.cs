using System;

namespace NameSorter
{
    public class Sorter
    {
        /// <summary>
        /// Reverses the order of words (seperated by a space) within each string stored in the given array.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        protected string[] ReverseValues(string[] values)
        {
            // Get the length of the array, so it isn't calculated on each pass of the for loop.
            int valuesLength = values.Length;

            // Create an empty array of the same length as given value array.
            string[] reversedValues = new string[valuesLength];

            // On each pass, split the index value string into single words
            // Reverse the order of the words and join back into string, putting the space back.
            // Store each reversed string in the new array. 
            for (int index = 0; index < valuesLength; index++)
            {
                string[] splitValue = values[index].Split(' ');
                Array.Reverse(splitValue);
                reversedValues[index] = string.Join(" ", splitValue);
            }

            // Return the populated array of reveresed strings.
            return reversedValues;
        }

        /// <summary>
        /// Sort the given array of strings in ascending alphabetical order from left to right.
        /// </summary>
        /// <param name="values">The strings to sort</param>
        protected void Sort(string[] values) {
            Array.Sort(values);
        }          
    }
}
