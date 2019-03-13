using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SpadesLib;

namespace SpadesTest
{
    [TestClass]
    public class RankTests
    {

        [TestMethod]
        public void MustReturn_The_Value_14_To_Ace()
        {
            Rank aceRank = Rank.ace;
            int expectedValue = 13;
            int testedValue = (int)aceRank;
            Assert.AreEqual(expectedValue, testedValue);
        }


    }
}
