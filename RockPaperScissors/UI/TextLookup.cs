using System;
using System.Collections.Generic;

using RockPaperScissors.Util;

namespace RockPaperScissors.UI
{
    public class TextLookup
    {
        private Dictionary<MoveType, string> _handDict = new Dictionary<MoveType, string>();
        private Dictionary<Outcome, string> _outcomeDict = new Dictionary<Outcome, string>();

        public TextLookup()
        {
            PopulateDictionaries();
        }

        public string GetText(MoveType hand)
        {
            return _handDict[hand];
        }

        public string GetText(Outcome outcome)
        {
            if(outcome == Outcome.UNDEFINED)
            {
                throw new Exception();
            }

            return _outcomeDict[outcome];
        }

        private void PopulateDictionaries()
        {
            _handDict.Add(MoveType.PAPER, Messages.DefinitionPaper);
            _handDict.Add(MoveType.ROCK, Messages.DefinitionRock);
            _handDict.Add(MoveType.SCISSORS, Messages.DefinitionScissors);

            _outcomeDict.Add(Outcome.WIN, Messages.DialogueWin);
            _outcomeDict.Add(Outcome.LOSE, Messages.DialogueLose);
            _outcomeDict.Add(Outcome.DRAW, Messages.DialogueDraw);
        }
    }
}
