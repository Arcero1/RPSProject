using System.Collections.Generic;

namespace RockPaperScissors.Util
{
    public class ScoreKeeper
    {
        private readonly Dictionary<Outcome, int> _scores = new Dictionary<Outcome, int>();
        public Dictionary<Outcome, int> Results
        {
            get { return _scores; }
        }


        public ScoreKeeper()
        {
            Init();
        }

        public void Update(Outcome outcome)
        {
            _scores[outcome]++;
        }

        private void Init()
        {
            _scores.Clear();
            _scores.Add(Outcome.WIN, 0);
            _scores.Add(Outcome.DRAW, 0);
            _scores.Add(Outcome.LOSE, 0);
        }

        public Outcome CalculateResult()
        {
            return _scores[Outcome.WIN] > _scores[Outcome.LOSE] ? Outcome.WIN :
                    _scores[Outcome.WIN] < _scores[Outcome.LOSE] ? Outcome.LOSE : Outcome.DRAW;
        }
    }
}
