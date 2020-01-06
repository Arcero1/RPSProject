using RockPaperScissors.Util;
using Xunit;

namespace RockPaperScissors.AI
{
    public class OpponentTest
    {
        ComputerPlayer opponent;

        [Fact]
        public void ClassicOpponentChosesRockPaperOrScissors()
        {
            opponent = new ComputerPlayer();

            MoveType move = opponent.GenerateNextMove();
            Assert.True(move == MoveType.ROCK || move == MoveType.PAPER || move == MoveType.SCISSORS);
        }

        [Fact]
        public void ExtendedOpponentChoosesAnyOfFiveMoves()
        {
            opponent = new ComputerPlayer(GameMode.EXTENDED);

            MoveType move = opponent.GenerateNextMove();
            Assert.True(move == MoveType.ROCK || move == MoveType.PAPER || move == MoveType.SCISSORS || move == MoveType.LIZARD || move == MoveType.SPOCK);
        }

        // test for randomness?
    }
}
