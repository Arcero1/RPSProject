using System;
using RockPaperScissors.Util;

namespace RockPaperScissors.AI
{
    public class Opponent
    {
        private Random _rng = new Random();
        private GameMode _mode = GameMode.CLASSIC;

        public Opponent()
        {}

        public Opponent(GameMode mode)
        {
            _mode = mode;
        }

        public MoveType Play()
        {
            if (_mode == GameMode.CLASSIC)
            {
                return (MoveType)_rng.Next(3);
            }

            // other modes not implemented yet
            throw new Exception();
        }
    }
}
