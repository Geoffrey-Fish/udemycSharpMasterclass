using static System.Console;

namespace SSE
    {
    public class Program
        {
        public static void Main(string[] args)
            {
            WriteLine("Welcome to TeacherDream2000.\n You may now enter the scores.\n When finished, please type '-1'.");
            Calculus();
            ReadLine();
            }
        private static void Calculus()
            {
            int score = 0;
            int counter = 0;
            int number;
            double finalScore;
            bool exit = false;
            while(exit == false)
                {
                WriteLine($"Count so far:{counter} Entries. \n Enter your next score and press enter:");
                bool success = int.TryParse(ReadLine(),out number);
                if(success)
                /* Example solution was this:
                 * If(int.TryParse(input,out currentNumber) && currentNumber > 0 && currentNummber < 21)*/
                    {
                    if(number == -1)
                        {
                        exit = true;
                        break;
                        }
                    /*Initially I forgot the negative number check! */
                    else if(number < -1 || number > 20)
                        {
                        WriteLine($"Please stay within 1 to 20. {number} does not match the requirement.");
                        continue;
                        }
                    else
                        {
                        score += number;
                        counter++;
                        }
                    }
                }
            /*He does double average = (double)total / (double)count;
             I'll test this here*/
            finalScore = (double)score / (double)counter;
            string fs = finalScore.ToString("N2");
            //finalScore = Math.Round(finalScore,2,MidpointRounding.AwayFromZero);
            WriteLine($"Okay, your total score is {fs} from {counter} Students.");
            }

        }
    }