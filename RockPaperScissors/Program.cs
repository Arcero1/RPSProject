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
            ComputerPlayer computer = new ComputerPlayer();
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

                computer.GenerateNextMove();


                UserInterface.DisplayOpponentHand(computer.NextMove.GetMoveType());
                Outcome outcome = player.Compare(computer.NextMove);
                computer.Compare(player.NextMove); // to 
                UserInterface.DisplayOutcome(outcome);
                UserInterface.DisplayScores(player.Results);
            } while (true);

            UserInterface.DisplayEndGameScreen(player.OverallResult);
            UserInterface.DisplayScores(player.Results);
            UserInterface.DisplayMoves(player.MostUsedMoves, player.MostUsedMovesFrequency);
        }

    }


}
