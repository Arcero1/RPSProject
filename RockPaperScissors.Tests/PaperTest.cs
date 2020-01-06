using RockPaperScissors.Util;
using Xunit;

namespace RockPaperScissors.Moves
{
    public class TestPaper
    {
        Move paper = new Paper();

        [Fact]
        public void HasMoveTypePaper()
        {
            Assert.Equal(MoveType.PAPER, paper.GetMoveType());
        }

        [Fact]
        public void BeatsRock()
        {
            Assert.Equal(Outcome.WIN, paper.Compare(MoveType.ROCK));
        }

        [Fact]
        public void DrawsPaper()
        {
            Assert.Equal(Outcome.DRAW, paper.Compare(MoveType.PAPER));
        }

        [Fact]
        public void LosesToScissors()
        {
            Assert.Equal(Outcome.LOSE, paper.Compare(MoveType.SCISSORS));
        }
    }
}
