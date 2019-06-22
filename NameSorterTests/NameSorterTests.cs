#pragma warning disable CS1701 // Assuming assembly reference matches identity
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NameSorter.Tests
{
    [TestClass]

    public class NameSorterTests
    {

        [TestMethod]
        public void Sort_CheckNamesArraySortByLastName()
        {
            string[] names = { "Robert Britton", "John Doe", "Anne Other", "Anne" };

            NameSorter ns = new NameSorter();
            string[] sortedNames = ns.SortByLastName(names);

            string[] expected = { "Anne", "Robert Britton", "John Doe", "Anne Other" };

            CollectionAssert.AreEqual(expected, sortedNames);
        }
    }
}
