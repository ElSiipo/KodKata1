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
        [DeploymentItem(@"test.txt")]
        public void HasLines()
        {
            FileReader fr = new FileReader(@"test.txt");
            
            bool _hasLines = false;

            if (fr.BlablaDictionary.Count > 0)
            {
                _hasLines = true;
            }

            Assert.AreEqual(true, _hasLines);
        }


        [TestMethod]
        [DeploymentItem(@"test.txt")]
        public void VerifyLineCount()
        {
            FileReader fr = new FileReader(@"test.txt");
            
            Assert.AreEqual(true, fr.BlablaDictionary.Count == 5);
        }


        [TestMethod]
        [DeploymentItem(@"test.txt")]
        public void IsWordExisting()
        {
            FileReader fr = new FileReader(@"test.txt");
            
            var isExisting = fr.IsWordExistingInList("apa");

            Assert.AreEqual(true, isExisting);
        }


        [TestMethod]
        [DeploymentItem(@"swedish.txt")]
        public void ExcludeWordsByLength()
        {
            FileReader fr = new FileReader(@"swedish.txt");
            
            fr.ExcludeWordsByCount();


            Assert.AreEqual(true, fr.BlablaDictionary.Where(p => p.Length > fr.InputWord.Count()));
        }
    }
}
