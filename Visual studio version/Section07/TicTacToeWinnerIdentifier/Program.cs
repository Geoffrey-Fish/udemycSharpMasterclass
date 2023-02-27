using static System.Console;
/*This time, you have to write only a checker for the game.
 * It will be a method that takes a 2D array and returns a boolean.
 * If there is a winner, it returns true otherwise false.
 * We use "X" and "O" as signs of our players.
 * The empty places will be filled with numbers from 1 to 9.
You have to check 3 types of cases:

horizontal;
vertical;
diagonal;

Hint: you can use more than one condition inside of one if, and don't hesitate to use loop;
*/

namespace section7
    {
    class Program
        {
        static void Main(string[] args)
            {
            WriteLine("Copied test from the course. Ill send an array now.");
            string[,] tester = new string[,] { { "1","2","X" },{ "4","8","O" },{ "X","X","X" } };

            bool test = Checker(tester,"X");
            WriteLine($" this game was : {test}");
            }
        public static bool Checker(string[,] b,string a)
            {
            if(b[0,0] == a && b[0,1] == a && b[0,2] == a)
                {
                return true;
                }
            else if(b[1,0] == a && b[1,1] == a && b[1,2] == a)
                {
                return true;
                }
            else if(b[2,0] == a && b[2,1] == a && b[2,2] == a)
                {
                return true;
                }
            else if(b[0,0] == a && b[1,0] == a && b[2,0] == a)
                {
                return true;
                }
            else if(b[0,1] == a && b[1,1] == a && b[2,1] == a)
                {
                return true;
                }
            else if(b[0,2] == a && b[1,2] == a && b[2,2] == a)
                {
                return true;
                }
            else if(b[0,0] == a && b[1,1] == a && b[2,2] == a)
                {
                return true;
                }
            else if(b[0,2] == a && b[1,1] == a && b[2,0] == a)
                {
                WriteLine("reverse x");
                return true;
                }
            else
                {
                WriteLine("Fuck");
                return false;
                }

            }
        }
    }

//Bug: The while loop in the Checker method will never end, as the value of x is always set to false.
// The return false statement should be outside of the while loop. Otherwise, the loop will never end and the function will never return true.
/*         Pseudo Code
            bool x = false;
            //Horizontal test
            x = b[0,0] == a && b[0,1] == a && b[0,2] == a ? true : false;
            x = b[1,0] == a && b[1,1] == a && b[1,2] == a ? true : false;
            x = b[2,0] == a && b[2,1] == a && b[2,2] == a ? true : false;
            //Vertical test
            x = b[0,0] == a && b[1,0] == a && b[2,0] == a ? true : false;
            x = b[0,1] == a && b[1,1] == a && b[2,1] == a ? true : false;
            x = b[0,2] == a && b[1,2] == a && b[2,2] == a ? true : false;
            //Diagonal test
            x = b[0,0] == a && b[1,1] == a && b[2,2] == a ? true : false;
            x = b[0,2] == a && b[1,1] == a && b[2,0] == a ? true : false;

            return x;

(board[0,0] == "X" && board[0,1] == "X" && board[0,2] == "X")
(board[0,0] == "O" && board[0,1] == "O" && board[0,2] == "O")
(board[0,0] == "X" && board[0,1] == "X" && board[0,2] == "X")
(board[0,0] == "O" && board[0,1] == "O" && board[0,2] == "O")
(board[0,0] == "X" && board[0,1] == "X" && board[0,2] == "X")
(board[0,0] == "O" && board[0,1] == "O" && board[0,2] == "O")


 * if 0 a und b und c  or 1 a und b und c or 2 a and b and c gleich
break
else go
    if a und a und a oder b und b und b oder c und c und c gleich
break
else go
    if 0a and 1b and 2c or 0c and 1b and 3a gleich
break
else
ende

//Horizontal test
x = b[0,0] == a ? b[0,1] == a ? b[0,2] == a ? true : false;
x = b[1,0] == a ? b[1,1] == a ? b[1,2] == a ? true : false;
x = b[2,0] == a ? b[2,1] == a ? b[2,2] == a ? true : false;
//Vertical test
x = b[0,0] == a ? b[1,0] == a ? b[2,0] == a ? true : false;
x = b[0,1] == a ? b[1,1] == a ? b[2,1] == a ? true : false;
x = b[0,2] == a ? b[1,2] == a ? b[2,2] == a ? true : false;
//Diagonal test
x = b[0,0] == a ? b[1,1] == a ? b[2,2] == a ? true : false;
x = b[0,2] == a ? b[1,1] == a ? b[2,0] == a ? true : false;

*/