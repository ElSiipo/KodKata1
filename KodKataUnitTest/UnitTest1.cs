using System;
using KodKata1;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KodKataUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        public void CanReadFile()
        {
            //FileReader fr = new FileReader("");
            //fr.ReadFile();

            //if (fr.BlablaSwedish.Count > 0)
            //{

            //}

            //Assert.AreEqual(true, canRead);
        }


        [TestMethod]
        public void HasLines()
        {
            FileReader fr = new FileReader(@"test.txt");
            fr.ReadFile();

            bool _hasLines = false;

            if (fr.BlablaDictionary.Count > 0)
            {
                _hasLines = true;
            }

            Assert.AreEqual(true, _hasLines);
        }


        [TestMethod]
        public void VerifyLineCount ()
        {
            FileReader fr = new FileReader(@"test.txt");
            fr.ReadFile();

            Assert.AreEqual(true, fr.BlablaDictionary.Count == 5);
        }


        [TestMethod]
        public void IsWordExisting()
        {
            FileReader fr = new FileReader(@"test.txt");
            fr.ReadFile();

            var isExisting = fr.IsWordExistingInList("apa");

            Assert.AreEqual(true, isExisting);
        }


        [TestMethod]
        public void ExcludeWordsByLength()
        {
            FileReader fr = new FileReader(@"swedish.txt");
            fr.ReadFile();

            fr.ExcludeWordsByCount();


            Assert.AreEqual(true, fr.BlablaDictionary.Where(p => p.Length > fr.InputWord.Count()));
        }
    }
}
