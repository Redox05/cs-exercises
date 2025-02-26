using BattleshipLiteLibrary;
using BattleshipLiteLibrary.Models;

namespace BattleshipLite
{
    class Program
    {
        static void Main(string[] args)
        {
            WelcomeMessage();

            PlayerInfoModel activePlayer = CreatePlayer("Player 1");
            PlayerInfoModel opponent = CreatePlayer("Player 2");
            PlayerInfoModel winner = null;

            do
            {
                DisplayShotGrid(activePlayer);

                RecordPlayerShot(activePlayer,  opponent);

                bool doesGameContinue = GameLogic.PlayerStillActive(opponent);

                if (doesGameContinue == true)
                {
                    // Swap using a tuple
                    (activePlayer, opponent) = (opponent, activePlayer);
                }
                else
                {
                    winner = activePlayer;
                }

            } while (winner == null);

            IdentifyWinner(winner);
        }

        private static void IdentifyWinner(PlayerInfoModel winner)
        {
            WriteLine($"Congratulations to {winner.UsersName} for winning!");
            WriteLine($"{winner.UsersName} took {GameLogic.GetShotCount(winner)} shots.");
        }

        private static void RecordPlayerShot(PlayerInfoModel activePlayer, PlayerInfoModel opponent) 
        {
            bool isValidShot = false;
            string row = "";
            int column = 0;

            do
            {
                string shot = AskForShot(activePlayer);
                try
                {
                    (row, column) = GameLogic.SplitShotIntoRowAndColumn(shot);
                    isValidShot = GameLogic.ValidateShot(activePlayer, row, column);
                }
                catch (Exception ex)
                {

                    isValidShot=false;
                }

                if (isValidShot == false)
                {
                    WriteLine("Invalid Shot Location. Try again.");
                }

            } while (!isValidShot);

            bool isAHit = GameLogic.IdentifyShotResult(opponent, row, column);

            GameLogic.MarkShotResult(activePlayer, row, column, isAHit);

            DisplayShotResults(row, column, isAHit);

        }

        private static void DisplayShotResults(string row, int column, bool isAHit)
        {
            if (isAHit)
            {
                WriteLine($"{row}{column} is a hit!");
            }
            else
            {
                WriteLine($"{row}{column} is a miss!");
            }
            WriteLine();
        }

        private static string AskForShot(PlayerInfoModel player)
        {
            Write($"{player.UsersName} -> Enter your shot selection: ");
            string output = ReadLine();
            return output;
        }

        private static void DisplayShotGrid(PlayerInfoModel activePlayer)
        {
            string currentRow = activePlayer.ShotGrid[0].SpotLetter;

            foreach (var gridSpot in activePlayer.ShotGrid)
            {
                if (gridSpot.SpotLetter != currentRow)
                {
                    WriteLine();
                    currentRow = gridSpot.SpotLetter;
                } 

                if(gridSpot.Status == GridSpotStatus.Empty)
                {
                    Write($" {gridSpot.SpotLetter}{gridSpot.SpotNumber} ");
                }
                else if (gridSpot.Status == GridSpotStatus.Hit)
                {
                    string shoot = "S";
                    Write($"{shoot,-4}");
                }
                else if (gridSpot.Status == GridSpotStatus.Miss)
                {
                    string miss = "M";
                    Write($"{miss,-4}");
                }
                else
                {
                    string question = "?";
                    Write($"{question}");
                }
            }
            WriteLine();
            WriteLine();
        }

        private static void WelcomeMessage()
        {
            WriteLine("Welcome to Battleship Lite");
            WriteLine("Created by Ruben Ortega, following IAMTimCorey's Master Course");
            WriteLine("");
        }

        private static PlayerInfoModel CreatePlayer(string playerTitle)
        {
            PlayerInfoModel output = new PlayerInfoModel();

            WriteLine($"Player information for {playerTitle}");

            //Ask user for their name
            output.UsersName = AskForUsersName();

            //Load up the shot grid
            GameLogic.InitializeGrid(output);

            //Ask the user for their 5 ship placements
            PlaceShips(output);

            //Clear 
            Clear();

            return output;

        }
        private static string AskForUsersName()
        {
            Write("Your name: ");
            string output = ReadLine();
            return output;
        }

        private static void PlaceShips(PlayerInfoModel model)
        {
            do
            {

                Write($"Where do you want to place your ship number {model.ShipLocations.Count + 1}: ");
                string location = ReadLine();

                bool isValidLocation = false;

                try
                {
                    isValidLocation = GameLogic.PlaceShip(model, location);
                }
                catch (Exception ex)
                {

                    WriteLine("Error: " + ex.Message);
                }

                if (isValidLocation == false)
                {
                    WriteLine("Not a valid location. Try again");
                }

            } while (model.ShipLocations.Count < 5);
        }
    }
}
