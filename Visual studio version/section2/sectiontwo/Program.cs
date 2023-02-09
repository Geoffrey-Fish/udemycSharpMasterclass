using static System.Console;
namespace ConstantsC
    {
    class Program
        {
        //constants as fields
        const double PI = 3.13159265359;
        const int weeks = 52, months = 12;
        const string birthday = "1985-04-17";

        static void Main(string[] args)
            {
            ForegroundColor = ConsoleColor.Green;
            BackgroundColor = ConsoleColor.Black;
            //this does not work because constant!
            //weeks = 39;
            WriteLine($"My Day is {birthday}");
            ReadKey();

            // Old stuff down here//////////////////////////////
            /*
            WriteLine("test one two");
            WriteLine("Please Enter your First Name");
            string name = ReadLine().ToLower();
            WriteLine("Please enter the Letter you want the Position for: ");
            string letter1 = ReadLine().ToLower();
            int answer = name.IndexOf(letter1);
            WriteLine("Now, what is your last Name?");
            string surname = ReadLine().ToLower();
            string fullname = name + " " + surname;
            WriteLine($"Your chosen Letter: {letter1} is on position: {answer} in Name: {name}.\n Thank you for your Time, {fullname}.");
            WriteLine();
            int init = 1;
            double duby = 1.2;
            float flo = 1.2345F; // that F is important
            decimal dec = 12.34M; // that M is important, too
            char cha = 'a'; // single quote for char
            string strig = "abcd"; // double quote for string!
            bool yes = false;
            bool no = true;

            string text1 = " I controll text";
            string text2 = "12345";
            WriteLine($"integer: {init}");
            WriteLine($"double: {duby}");
            WriteLine($"float: {flo}");
            WriteLine($"decimal: {dec}");
            WriteLine($"char: {cha}");
            WriteLine($"string: {strig}");
            WriteLine($"bool: {yes}");
            WriteLine($"bool:{no}");
            WriteLine($"sentence: {text1}");
            WriteLine($"sentence to number{int.Parse(text2)}");
            */
            }
        }
    }