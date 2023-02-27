using static System.Console;

namespace section7
    {
    class Program
        {
        static void Main(string[] args)
            {
            /*Initialize loop statement and map*/
            bool exit = false;
            string[,] gameField = new string[,] {
             {" ___","___ "," ___ "},
             {"|   |","   |","   |"},
             {"| 1 |"," 2 |"," 3 |"},
             {"|___|","___|","___|"},
             {"|   |","   |","   |"},
             {"| 4 |"," 5 |"," 6 |"},
             {"|___|","___|","___|"},
             {"|   |","   |","   |"},
             {"| 7 |"," 8 |"," 9 |"},
             {"|___|","___|","___|"},
            };
            /* Welcomme blabla */
            WriteLine("Welcome to tic tac toe ! \n" +
                "Are you guys ready for a Game? ");
            WriteLine("---------------------------");

            /* Main game loop*/
            while(exit == false)
                {

                /* Logic Player one*/
                printMap(gameField);
                WriteLine();

                gameField = playerOne(gameField);
                /*Checking win condition*/
                exit = MatchChecker.Checker(gameField,"X");
                if(exit)
                    {
                    WriteLine("Player one won the game!!!\n" +
                        "GG!");
                    WriteLine("_______________________________");


                    /* Logic Player two*/
                    printMap(gameField);
                    WriteLine();

                    gameField = playerTwo(gameField);
                    /*Checking win condition*/
                    exit = MatchChecker.Checker(gameField,"O");
                    if(exit)
                        {
                        WriteLine("Player two won the game!!!\n" +
                            "GG!");
                        WriteLine("_______________________________");
                        }
                    }
                }
            }


        public static string[,] playerOne(string[,] gameField)

            {
            WriteLine("Player one, pick a number!");
            Write("==> ");
            string? input1 = ReadLine();
            int i = Convert.ToInt32(a);
            if(i < 0 || i > 9)
                {
                WriteLine("Number too big or small.");
                }
            return Replacement(gameField,i,'X');
            }


        public static string[,] playerTwo(string[,] gameField)
            {
            WriteLine("Player two, pick a number!");
            Write("==> ");
            string? input2 = ReadLine();
            int i = Convert.ToInt32(a);
            if(i < 0 || i > 9)
                {
                WriteLine("Number too big or small,Dude,come on!");
                }
            return Replacement(gameField,i,'O');
            }


        /// <summary>
        /// replace number by sign of player
        /// </summary>
        /// <param name="b">number to replace</param>
        /// <param name="c">playersign</param>
        public static string[,] Replacement(string[,] a,int b,char c)
            {
            switch(b)
                {
                case 1:
                    a[2,0] = "| " + c + " |";
                    break;
                case 2:
                    a[2,1] = " " + c + " |";
                    break;
                case 3:
                    a[2,2] = " " + c + " |";
                    break;
                case 4:
                    a[5,0] = "| " + c + " |";
                    break;
                case 5:
                    a[5,1] = " " + c + " |";
                    break;
                case 6:
                    a[5,2] = " " + c + " |";
                    break;
                case 7:
                    a[8,0] = "| " + c + " |";
                    break;
                case 8:
                    a[8,1] = " " + c + " |";
                    break;
                case 9:
                    a[8,2] = " " + c + " |";
                    break;
                default:
                    WriteLine("Sumting Wong");
                    break;

                }
            return a;

            }


        /// <summary>
        /// print the gamefield
        /// 
        /// </summary>
        public static void printMap(string[,] gameField)
            {
            for(int i = 0;i < gameField.GetLength(0);i++)
                {
                for(int j = 0;j < gameField.GetLength(1);j++)
                    {
                    Write(gameField[i,j]);
                    }
                Write("\n");
                }
            }


        //////////
        }
    }
