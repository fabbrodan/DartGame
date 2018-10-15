using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DartGame
{
    class Dartboard
    {
        private int[] Points = new int[] { 20, 1, 18, 4, 13, 6, 10, 15, 2, 17, 3, 19, 7, 16, 8, 11, 14, 9, 12, 5 };
        private Random random;

        public Dartboard()
        {
            random = new Random();
        }

        public int ThrowDart()
        {
            int x = random.Next(20);
            return Points[x];
        }

    }
}
