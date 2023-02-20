using static System.Console;
/* This is a ternary challenge where you should enter a temperature.
 * If it is not in integer format, throw exception.
 * Else, answer corresponding to the value, 
 * evaluated via ternary operators
 */
namespace ternary
    {
    public class Program
        {
        static void Main(string[] args)
            {
            /*Endless loop config with exit option*/
            bool exit = false;
            while(exit == false)
                {
                WriteLine("Gimme a temperature!\n" +
                    "Whole Numbers only, between \n" +
                    "zero and 40. ");
                string? answer = ReadLine();
                /*Check if it is an integer via parsing it.
                 * Does it parse? Integer!Doesn't it? Throw Error!*/
                if(int.TryParse(answer,out int value))
                    {
                    WriteLine(TempMeter(value));
                    }
                else
                    {
                    WriteLine("Wrong Format! Try again!");
                    }
                WriteLine("Next Round? (Y)es, (N)o. ");
                string? stop = ReadLine().ToLower();
                exit = stop == "n" ? true : false;
                }

            }
        /*It is static string, but takes an integer as value, yes, that is correct and possible*/
        public static string TempMeter(int value)
            {
            /* here are the sample answers that will be returned*/
            string a = "Too cold out here!";
            string b = "It is ok";
            string c = "It is too hot here!";
            string d = "Error";
            /*And this is the evaluation via ternary*/
            string answer = value <= 15 ? a : value >= 16 && value <= 28 ? b : value > 28 ? c : d;
            return answer;


            }
        }
    }