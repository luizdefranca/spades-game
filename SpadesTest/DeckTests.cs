using Microsoft.VisualStudio.TestTools.UnitTesting;
using SpadesLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpadesLib.Tests
{
    [TestClass()]
    public class DeckTests
    {
        [TestMethod()]
        public void DeckTest_Create_Not_Null_Cards_Object()
        {
            MyDeck desk = new MyDeck();
            Cards cards = desk.GetCards();

            Assert.IsFalse(cards == null, "return a not null cards object");
        }

        class MyDeck : Deck
        {
            public Cards GetCards()
            {
                return base.cards;
            }
        }
    }
}