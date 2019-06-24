using System;

namespace NameSorter
{
    /// <summary>
    /// Provides a method for sorting a list of names.
    /// </summary>
    public abstract class AbstractNameSorter
    {
        /// <summary>
        /// An abstract method that should be overridden to provide sorting behaviour.
        /// </summary>
        /// <param name="names">The names to sort</param>
        /// <returns></returns>
        public abstract string[] Sort(string[] names);
    }
}
