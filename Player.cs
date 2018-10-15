using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DartGame
{
    class Player
    {
        private int TotalScore;
        private string Name;
        private List<Turn> PlayerTurns;

        public Player(string Name)
        {
            this.Name = Name;
            PlayerTurns = new List<Turn>();
            TotalScore = 0;
        }

        public override string ToString()
        {
            return this.Name;
        }

        public int GetScore()
        {
            return this.TotalScore;
        }

        public void AddTurn()
        {
            PlayerTurns.Add(new Turn());
            foreach (Turn turn in PlayerTurns)
            {
                TotalScore += turn.GetScore();
            }
        }
    }
}
