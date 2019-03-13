using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SpadesLib;

namespace SpadesLib.Tests
{
    [TestClass()]
    public class CardTest
    {
        [TestMethod()]
        public void EqualsTest()
        {
            Assert.Fail();
        }
    }

    class MyClass: Deck
    {
        public Card GetCard()
        {
           // return 
           
           return null;
        }
    }
}

namespace SpadesTest
{
    [TestClass]
    public class CardTests
    {
        [TestMethod]
        public void MustCreateAFourOfSpadeCard()
        {
            Card newCard = new Card(Suit.clubs, Rank.four);
            String expectedCardName="four_of_clubs";
            String testedCardName = newCard.ToString();
            Assert.AreEqual(newCard.ToString(), expectedCardName);

        }


    }
}
