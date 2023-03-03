namespace section7
    {
    class MatchChecker
        {
        /// <summary>
        /// This function checks the winning conditions
        /// </summary>
        /// <param name="b">playfield</param>
        /// <param name="a">Playersign</param>
        /// <returns></returns>
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
            else if(b[2,0] == "| " + a + " |" && b[5,0] == "| " + a + " |" && b[8,0] == "| " + a + " |")
                {
                return true;
                }
            else if(b[2,1] == " " + a + " |" && b[5,1] == " " + a + " |" && b[8,1] == " " + a + " |")
                {
                return true;
                }
            else if(b[2,2] == " " + a + " |" && b[5,2] == " " + a + " |" && b[8,2] == " " + a + " |")
                {
                return true;
                }
            else if(b[2,0] == "| " + a + " |" && b[5,1] == " " + a + " |" && b[8,2] == " " + a + " |")
                {
                return true;
                }
            else if(b[2,2] == " " + a + " |" && b[5,1] == " " + a + " |" && b[8,0] == "| " + a + " |")
                {
                return true;
                }
            else
                {
                return false;
                }

            }
        }
    }