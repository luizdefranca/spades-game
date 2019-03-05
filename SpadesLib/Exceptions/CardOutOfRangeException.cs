using System;

namespace SpadesLib.Exceptions
{
    public class CardOutOfRangeException :Exception
    {
        private Cards deskContents;

        public Cards DeskContents
        {
            get { return deskContents; }

        }

        public CardOutOfRangeException(Cards sourceDeskContents) : base("There are only 52 cards in the desk.")
        {
            deskContents = sourceDeskContents;
        }
    }
}