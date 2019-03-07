using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpadesLib
{
    public class Hand
    {
        private List<Card> hand;

        
        public Hand()
        {
            this.hand = new List<Card>();
        }

        public void Add(Card card)
        {
            int i = this.hand.Count();
            if ((i < 13))
            {
                this.hand.Add(card);
            }

            this.hand.Sort();
        }

        public bool Remove(Card card)
        {
            return this.hand.Remove(card);
        }

        public Card Remove(int position)
        {
            Card returnCard = this.hand[position];
            this.hand.Remove(returnCard);
            return returnCard;
        }

        public Card GetCardAtPosition(int position)
        {
            return this.hand[position];
        }

        public int GetNumSpades()
        {
            int numSpades = 0;
            foreach (Card aHand in this.hand)
            {
                if (aHand.suit.Equals(Suit.spades))
                {
                    numSpades++;
                }

            }

            return numSpades;
        }

        public String ToString()
        {
            return (this.hand.ToString() + (" Length: " + this.hand.Count()));
        }

        public bool Contains(Card c)
        {
            foreach (Card positinCard in this.hand)
            {
                if (positinCard.Equals(c))
                {
                    return true;
                }

            }

            return false;
        }

        public int Size()
        {
            return this.hand.Count();
        }
    }
}
