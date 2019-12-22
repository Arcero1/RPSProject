using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RockPaperScissors.Util
{
    public class MoveKeeper
    {
        private Dictionary<MoveType, int> _moves;

        public MoveKeeper(GameMode mode)
        {
            _moves = new Dictionary<MoveType, int>();

            foreach(MoveType move in MoveType.GetValues(typeof(MoveType)))
            {
                if (mode == GameMode.CLASSIC && (int)move > 2) break;

                _moves.Add(move, 0);
            }
        }

        public void Update(MoveType move)
        {
            _moves[move]++;
        }

        public List<MoveType> GetMostUsedMove()
        {
            List<MoveType> moves = new List<MoveType>();

            var keys = from entry in _moves
                       where entry.Value == GetMostUsedMoveInstanceNumber()
            select entry.Key;

            foreach (var key in keys)
                moves.Add(key);

            return moves;
        }

        public int GetMostUsedMoveInstanceNumber()
        {
            return _moves.Values.Max();
        }
    }
}
