using RockPaperScissors.AI;
using RockPaperScissors.Moves;
using RockPaperScissors.UI;
using RockPaperScissors.Util;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Opponent computer = new Opponent();
            Player player = new Player();

            UserInterface.DisplayWelcomeScreen();

            do
            {
                Move move;

                try
                { 
                    move = UserInterface.QueryNextHand();
                }
                catch
                {
                    break;
                }

                MoveType computerMove = computer.Play();
                

                UserInterface.DisplayOpponentHand(computerMove);
                Outcome outcome = player.Play(move, computerMove);
                UserInterface.DisplayOutcome(outcome);
                UserInterface.DisplayScores(player.GetScores());
            } while (true);

            UserInterface.DisplayEndGameScreen(player.GetResult());
            UserInterface.DisplayScores(player.GetScores());
            UserInterface.DisplayMoves(player.GetMostUsedMoves(), player.GetMostUsedMoveInstanceNumber());
        }

    }

    
}
