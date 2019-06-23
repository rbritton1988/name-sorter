#pragma warning disable CS1701 // Assuming assembly reference matches identity
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NameSorter.UnitTests.Sort
{
    [TestClass]
    public class NameSorter_Sort
    {
        protected readonly NameSorter nameSorter;

        public NameSorter_Sort()
        {
            nameSorter = new NameSorter();
        }

        [TestMethod]
        public void UnsortedNamesIn_SortedNamesReturned()
        {
            string[] names = { "John Doe", "Anne Other", "Anne", "Joseph Emanuel Isaac David"};
            string[] sortedNames = nameSorter.SortByLastName(names);
            string[] expected = { "Anne", "Joseph Emanuel Isaac David", "John Doe", "Anne Other" };
            CollectionAssert.AreEqual(expected, sortedNames);
        }

        [TestMethod]
        public void OneNameIn_OneNameReturned()
        {
            string[] names = { "Robert Britton" };
            string[] sortedNames = nameSorter.SortByLastName(names);
            string[] expected = { "Robert Britton"};
            CollectionAssert.AreEqual(expected, sortedNames);
        }


        [TestMethod]
        public void EmptyArrayIn_Throws()
        {
            string[] names = { };
            // Make sure an Exception is thrown if the names list is empty
            // As there's little point to sorting nothing.
            Assert.ThrowsException<Exception>(() => nameSorter.SortByLastName(names));

        }
    }
}
