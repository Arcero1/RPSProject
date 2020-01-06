using RockPaperScissors.Moves;
using RockPaperScissors.Util;
using System.Collections.Generic;

namespace RockPaperScissors.AI
{
    public class Player
    {
        private readonly ScoreKeeper _scoreKeeper = new ScoreKeeper();
        private readonly MoveKeeper _moveKeeper;

        protected Move _nextMove;
        public Move NextMove
        {
            get { return _nextMove; }
        }

        public Player()
        {
            _moveKeeper = new MoveKeeper(GameMode.CLASSIC);
        }

        public Player(GameMode mode)
        {
            _moveKeeper = new MoveKeeper(mode);
        }

        public Outcome Compare(Move opponentMove)
        {
            Outcome outcome = _nextMove.Compare(opponentMove);

            _moveKeeper.Update(_nextMove.GetMoveType());
            _scoreKeeper.Update(outcome);

            return outcome;
        }

        public Outcome OverallResult
        {
            get { return _scoreKeeper.CalculateResult(); }
        }

        public Dictionary<Outcome, int> Results
        {
            get { return _scoreKeeper.Results; }
        }

        public List<MoveType> MostUsedMoves
        {
            get { return _moveKeeper.MostUsed; }
        }

        public int MostUsedMovesFrequency
        {
            get { return _moveKeeper.MostUsedFrequency; }
        }
    }
}
