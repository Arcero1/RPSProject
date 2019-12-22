using Xunit;

using RockPaperScissors.Util;

namespace RockPaperScissors.Moves
{
    public class TestScissors
    {
        Move scissors = new Scissors();

        [Fact]
        public void HasMoveTypeScissors()
        {
            Assert.Equal(MoveType.SCISSORS, scissors.GetMoveType());
        }

        [Fact]
        public void BeatsPaper()
        {
            Assert.Equal(Outcome.WIN, scissors.Compare(MoveType.PAPER));
        }

        [Fact]
        public void DrawsScissors()
        {
            Assert.Equal(Outcome.DRAW, scissors.Compare(MoveType.SCISSORS));
        }

        [Fact]
        public void LosesToPaper()
        {
            Assert.Equal(Outcome.LOSE, scissors.Compare(MoveType.ROCK));
        }
    }
}
