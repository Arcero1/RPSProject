using RockPaperScissors.Util;
using Xunit;

namespace RockPaperScissors.Moves
{
    public class TestRock
    {
        Move rock = new Rock();

        [Fact]
        public void RockHasMoveTypeRock()
        {
            Assert.Equal(MoveType.ROCK, rock.GetMoveType());
        }

        [Fact]
        public void RockBeatsScissors()
        {
            Assert.Equal(Outcome.WIN, rock.Compare(MoveType.SCISSORS));
        }

        [Fact]
        public void RockDrawsRock()
        {
            Assert.Equal(Outcome.DRAW, rock.Compare(MoveType.ROCK));
        }

        [Fact]
        public void RockLosesToPaper()
        {
            Assert.Equal(Outcome.LOSE, rock.Compare(MoveType.PAPER));
        }
    }
}
