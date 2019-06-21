using System;
using System.Collections.Generic;
using System.Text;

namespace NameSorter.Interface
{
    abstract class AbstractSorter
    {
        virtual protected string[] ReverseValues(string[] values)
        {
            int valuesLength = values.Length;

            string[] reversedValues = new string[valuesLength];

            for (int index = 0; index < valuesLength; index++)
            {
                string[] splitValue = values[index].Split(' ');
                Array.Reverse(splitValue);
                reversedValues[index] = string.Join(" ", splitValue);
            }

            return reversedValues;
        }

        virtual protected void Sort(string[] values) {
            Array.Sort(values);
        }          
    }
}
