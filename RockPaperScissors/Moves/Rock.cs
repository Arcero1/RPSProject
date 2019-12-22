using RockPaperScissors.Util;

namespace RockPaperScissors.Moves
{
    public class Rock : Move
    {
        public Rock()
        {
            SetOutcome(MoveType.ROCK, Outcome.DRAW);
            SetOutcome(MoveType.PAPER, Outcome.LOSE);
            SetOutcome(MoveType.SCISSORS, Outcome.WIN);
        }

        public override MoveType GetMoveType()
        {
            return MoveType.ROCK;
        }
    }
}
