using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpadesLib
{
    public class Player
    {
       
        private Hand myHand; 
        private bool isTheTurnToPlay; 
        private String name; 

        public Player()
        {
            name = "Player";
            myHand = new Hand();
        }

        
        public Player(String n)
        {
            name = n;
            myHand = new Hand();
        }

        public void Name(String name)
        {
            this.name = name;
        }

        public String Name()
        {
            return name;
        }

        public void Hand(Hand hand)
        {
            myHand = hand;
        }

        public Hand Hand()
        {
            return myHand;
        }


        bool TurnToPlay()
        {
            return isTheTurnToPlay;
        }

        
        void TurnToPlay(bool turn)
        {
            isTheTurnToPlay = turn;
        }
    }
}
