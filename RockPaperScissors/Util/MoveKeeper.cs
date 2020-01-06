using System.Collections.Generic;
using System.Linq;

namespace RockPaperScissors.Util
{
    public class MoveKeeper
    {
        private readonly Dictionary<MoveType, int> _moves;
        public List<MoveType> MostUsed
        {
            get
            {
                List<MoveType> moves = new List<MoveType>();

                var keys = from entry in _moves
                           where entry.Value == MostUsedFrequency
                           select entry.Key;

                foreach (var key in keys)
                    moves.Add(key);

                return moves;
            }
        }
        public int MostUsedFrequency
        {
            get { return _moves.Values.Max(); }
        }

        public MoveKeeper(GameMode mode)
        {
            _moves = new Dictionary<MoveType, int>();
            Init(mode);
        }

        // Initiates the move frequency table with appropriate moves for the game mode
        // Sets each move frequency to 0
        private void Init(GameMode mode)
        {
            _moves.Clear();
            foreach (MoveType move in MoveType.GetValues(typeof(MoveType)))
            {
                if (mode == GameMode.CLASSIC && (int)move > 2) break;

                _moves.Add(move, 0);
            }
        }

        public void Update(MoveType move)
        {
            _moves[move]++;
        }
    }
}
