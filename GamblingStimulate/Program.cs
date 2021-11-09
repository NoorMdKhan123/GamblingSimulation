using System;

namespace GamblingStimulate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Gambling Stimualte program");
            StakeBet stakeBet = new StakeBet();
            stakeBet.StartGame();
        }
    }
}
