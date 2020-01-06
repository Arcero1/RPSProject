namespace RockPaperScissors.UI
{
    public struct Messages
    {
        // Errors
        public const string ErrorIncorrectOutput = "Incorrect Input";

        // Dialogues
        public const string DialogueStartGame = "Hello";
        public const string DialogueOpponentMove = "Your opponent has chosen: ";
        public const string DialogueWin = "You WIN!";
        public const string DialogueLose = "You LOSE!";
        public const string DialogueDraw = "Draw!";
        public const string DialogueEndGame = "The game has ended.";
        public const string DialoguePreFinalScores = "The final scores are:";

        // Definitions
        public const string DefinitionRock = "ROCK";
        public const string DefinitionPaper = "PAPER";
        public const string DefinitionScissors = "SCISSORS";

        // User Queries
        public const string QueryNextMove = "Press a button to chose your next move:" +
            "\n [r] " + DefinitionRock +
            "\n [p] " + DefinitionPaper +
            "\n [s] " + DefinitionScissors;
        public const string QueryEndGame = " Press [x] to quit";
    }
}
