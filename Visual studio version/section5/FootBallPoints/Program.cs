using static System.Console;

namespace scoring
    {
    class Program
        {
        public static string player = "Hans";
        public static int highscore = 1;

        static void Main(string[] args)
            {
            bool exit = false;
            while(exit == false)
                {
                    {
                    Comparer();
                    WriteLine("For a second round, press Enter." +
                        " \n For E(x)it, press x key");
                    string? ex = ReadLine();
                    if(ex == "x")
                        {
                        exit = true;
                        }
                    }
                }
            public static void Comparer()
                {
                WriteLine("Tell me the name of the new Player: ");
                string? playerName = ReadLine();
                WriteLine($"What was {playerName}'s Highscore? ");
                int playerNow = Convert.ToInt32(ReadLine());
                if(playerNow > highscore)
                    {
                    WriteLine($"New Highscore achieved by {playerName} with {playerNow} points in total!");
                    player = playerName;
                    highscore = playerNow;

                    }
                else
                    {
                    WriteLine($"Sorry, but {playerName} did not beat the highscore of {highscore} by {player}.");

                    }

                }
            }
        }