using RockPaperScissors.Util;

namespace RockPaperScissors.Moves
{
    public class Scissors : Move
    {
        public Scissors()
        {
            SetOutcome(MoveType.ROCK, Outcome.LOSE);
            SetOutcome(MoveType.PAPER, Outcome.WIN);
            SetOutcome(MoveType.SCISSORS, Outcome.DRAW);
        }

        public override MoveType GetMoveType()
        {
            return MoveType.SCISSORS;
        }
    }
}
