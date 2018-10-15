using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DartGame
{
    class Turn
    {
        private Dartboard Board = new Dartboard();
        private int Score = 0;

        public Turn()
        {

        }

        public int GetScore()
        {
            for (int i = 0; i < 3; i++)
            {
                Score += Board.ThrowDart();
            }

            return Score;
        }
        
    }
}
