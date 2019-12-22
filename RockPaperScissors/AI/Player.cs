using System;
using System.Collections.Generic;
using System.Text;

using RockPaperScissors.Util;
using RockPaperScissors.Moves;
using RockPaperScissors.UI;

namespace RockPaperScissors.AI
{
    public class Player
    {
        ScoreKeeper scoreKeeper;
        MoveKeeper moveKeeper;

        public Player(GameMode mode)
        {
            scoreKeeper = new ScoreKeeper();
            moveKeeper = new MoveKeeper(mode);
        }

        public Player()
        {
            scoreKeeper = new ScoreKeeper();
            moveKeeper = new MoveKeeper(GameMode.CLASSIC);
        }

        public Outcome Play(Move move, MoveType opponentMove)
        {
            moveKeeper.Update(move.GetMoveType());
            Outcome outcome = move.Compare(opponentMove);
            scoreKeeper.Update(outcome);
            return outcome;
        }

        public Outcome GetResult()
        {
            return scoreKeeper.GetOverallOutcome();
        }

        public Dictionary<Outcome, int> GetScores()
        {
            return scoreKeeper.GetScores();
        }

        public List<MoveType> GetMostUsedMoves()
        {
            return moveKeeper.GetMostUsedMove();
        }

        public int GetMostUsedMoveInstanceNumber()
        {
            return moveKeeper.GetMostUsedMoveInstanceNumber();
        }
    }
}
