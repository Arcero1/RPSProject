using System.Collections.Generic;

using RockPaperScissors.Util;

namespace RockPaperScissors.Moves
{
    abstract public class Move
    {
        private Dictionary<MoveType, Outcome> outcomeDictionary = new Dictionary<MoveType, Outcome>();

        public Move()
        {
            outcomeDictionary.Add(MoveType.PAPER, Outcome.UNDEFINED);
            outcomeDictionary.Add(MoveType.ROCK, Outcome.UNDEFINED);
            outcomeDictionary.Add(MoveType.SCISSORS, Outcome.UNDEFINED);
        }

        protected void SetOutcome(MoveType hand, Outcome outcome)
        {
            outcomeDictionary[hand] = outcome;
        }

        public Outcome Compare(MoveType hand)
        {
            return outcomeDictionary[hand];
        }

        public abstract MoveType GetMoveType();
    }
}
