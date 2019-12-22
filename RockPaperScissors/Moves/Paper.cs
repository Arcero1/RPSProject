using RockPaperScissors.Util;

namespace RockPaperScissors.Moves
{
    public class Paper : Move
    {
        public Paper()
        {
            SetOutcome(MoveType.ROCK, Outcome.WIN);
            SetOutcome(MoveType.PAPER, Outcome.DRAW);
            SetOutcome(MoveType.SCISSORS, Outcome.LOSE);
        }

        public override MoveType GetMoveType()
        {
            return MoveType.PAPER;
        }
    }
}
