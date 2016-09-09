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
        [DeploymentItem(@"test.txt")]
        public void HasLines()
        {
            FileReader fr = new FileReader(@"test.txt");
            Assert.AreEqual(true, fr.BlablaDictionary.Count > 0);
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
            Assert.AreEqual(true, fr.IsWordExistingInList("apa"));
        }


        [TestMethod]
        [DeploymentItem(@"swedish.txt")]
        public void ExcludeWordsByLength()
        {
            FileReader fr = new FileReader(@"swedish.txt");

            fr.InputWord = "hatt";
            fr.ExcludeWordsByCount();

            bool largerThanZero = ((fr.BlablaDictionary.Where(p => p.Length != fr.InputWord.Length)).Count() > 0);
            Assert.AreEqual(false, largerThanZero);
        }
    }
}
