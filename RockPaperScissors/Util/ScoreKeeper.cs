using System;
using System.Collections.Generic;
using System.Linq;

namespace RockPaperScissors.Util
{
    public class ScoreKeeper
    {
        private Dictionary<Outcome, int> _scores = new Dictionary<Outcome, int>();

        public ScoreKeeper()
        {
            _scores.Add(Outcome.WIN, 0);
            _scores.Add(Outcome.DRAW, 0);
            _scores.Add(Outcome.LOSE, 0);
        }

        public void Update(Outcome outcome)
        {
            _scores[outcome]++;
        }

        public Dictionary<Outcome, int> GetScores()
        {
            return _scores;
        }

        public void Reset()
        {
            _scores[Outcome.WIN] = 0;
            _scores[Outcome.LOSE] = 0;
            _scores[Outcome.DRAW] = 0;
        }

        public Outcome GetOverallOutcome()
        {
            return _scores[Outcome.WIN] > _scores[Outcome.LOSE] ? Outcome.WIN : 
                _scores[Outcome.WIN] < _scores[Outcome.LOSE] ? Outcome.LOSE : Outcome.DRAW;
        }
    }
}
