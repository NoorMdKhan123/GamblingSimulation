using System;
using System.Collections.Generic;
using System.Text;

namespace GamblingStimulate
{
    public class StakeBet
    {

        public int stake_per_day = 100;
        public int per_game_bet = 1;
        public int lose = 0;
        public int win = 1;

        public void StartGame()
        {
            Random random = new Random();
            int result = random.Next(0, 2);

            if (result == win)
            {
                win = win + per_game_bet;
                Console.WriteLine("Gambler won 1st bet", win);
            }
            else
            {
                Console.WriteLine("Gambler lost");
            }

        }
    }

}
