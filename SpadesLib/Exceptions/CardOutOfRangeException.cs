using System;
using System.Runtime.Serialization;

namespace SpadesLib.Exceptions
{
    [Serializable]
    public class CardOutOfRangeException :Exception, ISerializable
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