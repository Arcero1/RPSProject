using System;
using System.Collections.Generic;
using Xunit;

namespace RockPaperScissors.Util
{
    public class ScoreKeeperTest
    {
        ScoreKeeper scoreKeeper;

        [Fact]
        public void KeepsScoresCorrectly()
        {
            int n = 100;
            Random rng = new Random();
            int[] winsDrawsLosses = new int[3];

            for (int i = 0; i < 3; i++)
            {
                winsDrawsLosses[i] = rng.Next(n);
                Outcome outcome = (Outcome)i;

                for (int j = 0; j < winsDrawsLosses[i]; j++)
                {
                    scoreKeeper.Update(outcome);
                }
            }

            Dictionary<Outcome, int> scoreKeeperOutput = scoreKeeper.GetScores();

            Assert.Equal(winsDrawsLosses[0], scoreKeeperOutput[Outcome.WIN]);
            Assert.Equal(winsDrawsLosses[1], scoreKeeperOutput[Outcome.DRAW]);
            Assert.Equal(winsDrawsLosses[2], scoreKeeperOutput[Outcome.LOSE]);
        }
    }
}