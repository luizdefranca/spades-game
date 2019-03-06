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
            
        }

        public Card(Suit suit, Rank rank)
        {
            this.rank = rank;
            this.suit = suit;
        }

        public override string ToString() => $"{rank.ToString()}_of_{suit.ToString()}";


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

        /*
         * TO-DO
         */
        public int CompareTo(Object obj)
        {

            Card secondCard = (Card) obj;
            Suit suitFirstCard, suitSecondCard;
                
            // Set a suit order for the first
            suitFirstCard =  this.suit;

            // set a suit order for the second
            suitSecondCard = secondCard.suit;

            if (this.suit.Equals(secondCard.suit))
            {
                if ((int) this.rank < (int) secondCard.rank)
                    return -1;
                else
                    return 1;
            }
            else
            {
                if (this.suit.Equals(Suit.spades))
                {
                    return 1;
                } 
                if (secondCard.suit.Equals(Suit.spades))
                {
                    return -1;
                }
                if (suitFirstCard < suitSecondCard)
                    return -1;
                else
                    return 1;
            }
            

        }
    }
}