using Xunit;

using RockPaperScissors.Util;

namespace RockPaperScissors.AI
{
    public class OpponentTest
    {
        Opponent opponent;

        [Fact]
        public void ClassicOpponentChosesRockPaperOrScissors()
        {
            opponent = new Opponent();

            MoveType move = opponent.Play();
            Assert.True(move == MoveType.ROCK || move == MoveType.PAPER || move == MoveType.SCISSORS);
        }

        [Fact]
        public void ExtendedOpponentChoosesAnyOfFiveMoves()
        {
            opponent = new Opponent(GameMode.EXTENDED);

            MoveType move = opponent.Play();
            Assert.True(move == MoveType.ROCK || move == MoveType.PAPER || move == MoveType.SCISSORS || move == MoveType.LIZARD || move == MoveType.SPOCK);
        }

        // test for randomness?
    }
}
