#pragma warning disable CS1701 // Assuming assembly reference matches identity
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace NameSorter.Writer.UnitTests
{
    [TestClass]
    public class TextFileWriter_Constructor
    {
        [TestMethod]
        public void EmptyFileNameIn_Throws()
        {
            Assert.ThrowsException<Exception>(() => new TextFileWriter(""));
        }

    }

    [TestClass]
    public class TextFileWriter_Static_GetLegalFileName
    {
        [TestMethod]
        public void IllegalFileName_ReturnsLegalFileName()
        {
            string illegalFileName = ".<.";
            string safeName = TextFileWriter.GetSafeFilename(illegalFileName);
            string expected = "___";
            Assert.AreEqual(expected, safeName);
        }
    }
}
