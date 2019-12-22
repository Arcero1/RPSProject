using System;
using System.Collections.Generic;

using RockPaperScissors.Util;
using RockPaperScissors.Moves;
using System.Linq;

namespace RockPaperScissors.UI
{
    // Exchanges information with the human player
    public static class UserInterface
    {
        private static TextLookup _text = new TextLookup();

        public static void DisplayWelcomeScreen()
        {
            Console.WriteLine(Messages.DialogueStartGame);
        }

        public static void DisplayOpponentHand(MoveType hand)
        {
            Console.WriteLine(Messages.DialogueOpponentMove + _text.GetText(hand));
        }

        public static void DisplayOutcome(Outcome outcome)
        {
            Console.WriteLine(_text.GetText(outcome));
        }

        public static void DisplayEndGameScreen(Outcome outcome)
        {
            Console.WriteLine(Messages.DialogueEndGame);
            Console.WriteLine(outcome == Outcome.WIN ? Messages.DialogueWin : 
                outcome == Outcome.LOSE ? Messages.DialogueLose : Messages.DialogueDraw);
            Console.WriteLine(Messages.DialoguePreFinalScores);
        }

        public static Move QueryNextHand()
        {
            Console.WriteLine(Messages.QueryNextMove);
            Console.WriteLine(Messages.QueryEndGame);

            switch (Console.ReadLine())
            {
                case ("R"):
                case ("r"):
                    return new Rock();
                case ("P"):
                case ("p"):
                    return new Paper();
                case ("S"):
                case ("s"):
                    return new Scissors();
                case ("X"):
                case ("x"):
                    throw new Exception();
                default:
                    Console.WriteLine(Messages.ErrorIncorrectOutput);
                    return QueryNextHand();
            }

            throw new Exception(); // TODO: change this to a custom exception
        }

        public static void DisplayScores(Dictionary<Outcome, int> scores)
        {
            Console.WriteLine("Games Played: " + (scores.Values.Sum()));
            Console.WriteLine("Stats: " + scores[Outcome.WIN] + "W / " + scores[Outcome.DRAW] + "D / " + scores[Outcome.LOSE] + "L");

        }

        public static void DisplayMoves(List<MoveType> moves, int timesUsed)
        {
            bool first = true;
            Console.Write("Your most used move(s): ");

            foreach (MoveType move in moves)
            {
                if (first == false) Console.Write(", ");
                Console.Write(_text.GetText(move));

                first = false;
            }

            Console.WriteLine();
            Console.WriteLine("Used " + timesUsed + " times");
        }


    }
}
