using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpadesLib
{
    public class Card : ICloneable, IComparable
    {
        public readonly Rank rank;
        public readonly Suit suit;
        
      
        private Card()
        {
            throw new System.NotImplementedException();
        }

        public Card(Suit suit, Rank rank)
        {
            throw new System.NotImplementedException();
        }

        public override string ToString() => $"{rank}_of_{suit}";


        public object Clone() => MemberwiseClone();

        // override object.Equals
        public override bool Equals(object obj)
        {
           
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Card otherCard = (Card) obj;

            if (suit.Equals(otherCard.suit) && rank.Equals(otherCard.rank))
            {
                return true;
            }

            return false;


        }


        
        // override object.GetHashCode
        public override int GetHashCode()
        {
           
            return base.GetHashCode();
        }

        public int CompareTo(Card secondCard)
        {
            int suitFirstCard, suitSecondCard;
                
            // Set a suit order for the first
            suitFirstCard = (int) this.suit;

            // set a suit order for the second
            suitSecondCard = (int) secondCard.suit;

            if (this.suit.Equals(secondCard.suit))
            {
                if ((int) this.rank < (int) secondCard.rank)
                    return -1;
                else
                    return 1;
            }
            if (suitFirstCard < suitSecondCard)
                return -1;
            else
                return 1;

        }
    }
}