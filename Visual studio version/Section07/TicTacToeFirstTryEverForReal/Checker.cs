using static System.Console;

namespace section7
    {
    class MatchChecker
        {

        public static bool Checker(string[,] b,string a)
            {
            if(b[2,0] == "| " + a + " |" && b[2,1] == " " + a + " |" && b[2,2] == " " + a + " |")
                {
                return true;
                }
            else if(b[5,0] == "| " + a + " |" && b[5,1] == " " + a + " |" && b[5,2] == " " + a + " |")
                {
                return true;
                }
            else if(b[8,0] == "| " + a + " |" && b[8,1] == " " + a + " |" && b[8,2] == " " + a + " |")
                {
                return true;
                }
            else if(b[2,0] == "| " + a + " |" && b[5,0] == " " + a + " |" && b[8,0] == " " + a + " |")
                {
                return true;
                }
            else if(b[2,1] == "| " + a + " |" && b[5,1] == " " + a + " |" && b[8,1] == " " + a + " |")
                {
                return true;
                }
            else if(b[2,2] == "| " + a + " |" && b[5,2] == " " + a + " |" && b[8,2] == " " + a + " |")
                {
                return true;
                }
            else if(b[2,0] == "| " + a + " |" && b[5,1] == " " + a + " |" && b[8,2] == " " + a + " |")
                {
                return true;
                }
            else if(b[2,2] == "| " + a + " |" && b[5,1] == " " + a + " |" && b[8,0] == " " + a + " |")
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