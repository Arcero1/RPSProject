using RockPaperScissors.Moves;
using RockPaperScissors.Util;

namespace RockPaperScissors.AI
{
    class HumanPlayer : Player
    {
        public new Move NextMove
        {
            get { return _nextMove; }
            set { _nextMove = NextMove; }
        }

        public HumanPlayer()
        {
        }

        public HumanPlayer(GameMode mode) : base(mode)
        {
        }
    }
}
