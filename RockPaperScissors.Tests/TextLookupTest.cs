using System;
using Xunit;

using RockPaperScissors.Util;

namespace RockPaperScissors.UI
{
    public class TextLookupTest
    {
        TextLookup lookup = new TextLookup();

        [Fact]
        public void ClassicGetMoveTextReturnsANonEmptyString()
        {
            foreach(MoveType move in MoveType.GetValues(typeof(MoveType))) {
                if ((int)move > 2) break;

                Assert.IsType<string>(lookup.GetText(move));
                Assert.NotEqual("", lookup.GetText(move));
            }
        }

        // technically, I think I should go through each checking against "Messages"
        // that would require me to repeat the code, however - I'm not sure how desirable that would be
        // I will add it below for completeness

        [Fact]
        public void ClassicGetMoveReturnsDefinition()
        {
            Assert.Equal(Messages.DefinitionRock, lookup.GetText(MoveType.ROCK));
            Assert.Equal(Messages.DefinitionPaper, lookup.GetText(MoveType.PAPER));
            Assert.Equal(Messages.DefinitionScissors, lookup.GetText(MoveType.SCISSORS));
        }

        [Fact]
        public void GetOutcomeTextReturnsANonEmptyString()
        {
            foreach (Outcome outcome in Outcome.GetValues(typeof(Outcome)))
            {
                if (outcome == Outcome.UNDEFINED) continue;

                Assert.IsType<string>(lookup.GetText(outcome));
                Assert.NotEqual("", lookup.GetText(outcome));
            }
        }

        [Fact]
        public void GetOutcomeReturnsCorrectDialogue()
        {
            Assert.Equal(Messages.DialogueWin, lookup.GetText(Outcome.WIN));
            Assert.Equal(Messages.DialogueLose, lookup.GetText(Outcome.LOSE));
            Assert.Equal(Messages.DialogueDraw, lookup.GetText(Outcome.DRAW));
        }

        [Fact]
        public void UndefinedOutcomeThrowsException()
        {
            Assert.Throws<Exception>(() => lookup.GetText(Outcome.UNDEFINED));
        }
    }
}