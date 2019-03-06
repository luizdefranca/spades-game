using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace SpadesLib
{
    class Program
    {
        static void Main(string[] args)
        {
            Card newCard = new Card(Suit.clubs, Rank.four);
            WriteLine(newCard);
        }
    }
}
