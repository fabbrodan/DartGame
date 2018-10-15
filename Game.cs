using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DartGame
{
    class Game
    {
        private List<Player> PlayerList;

        public Game()
        {
            PlayerList = new List<Player>();
        }

        public void AddPlayer(string Name)
        {
            PlayerList.Add(new Player(Name));
        }

        public IEnumerable<Player> GetPlayers ()
        {
            return this.PlayerList;
        }

        public void PlayGame()
        {
            foreach (Player player in PlayerList)
            {
                player.AddTurn();
            }
        }

    }
}
