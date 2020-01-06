using RockPaperScissors.Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors.Moves
{
    static class MoveGenerator
    {
        public static Move Generate(MoveType moveType)
        {
            switch (moveType)
            {
                case (MoveType.ROCK):
                    return new Rock();
                case (MoveType.PAPER):
                    return new Paper();
                case (MoveType.SCISSORS):
                    return new Scissors();
                default:
                    throw new Exception();
            }
        }
    }
}
