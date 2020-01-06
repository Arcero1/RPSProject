using RockPaperScissors.Moves;
using RockPaperScissors.Util;
using System;

namespace RockPaperScissors.AI
{
    public class ComputerPlayer : Player
    {
        private Random _rng = new Random();
        private GameMode _mode = GameMode.CLASSIC;

        public ComputerPlayer()
        {
        }

        public ComputerPlayer(GameMode mode) : base(mode)
        {
            _mode = mode;
        }

        public Move GenerateNextMove()
        {
            if (_mode == GameMode.CLASSIC)
            {
                _nextMove = MoveGenerator.Generate((MoveType)_rng.Next(3));
                return _nextMove;
            }

            // other modes not implemented yet
            throw new Exception();
        }
    }
}
