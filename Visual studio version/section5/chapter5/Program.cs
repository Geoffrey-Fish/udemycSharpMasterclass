using static System.Console;

/*Challenge)*/
/*This was my attempt. Wasnt the proper way, though*/
//WriteLine("Welcome!Please enter a user name:");
//string? unamel = ReadLine();
//WriteLine("Now, a password:");
//string? pw = ReadLine();
//WriteLine("Thank you.\n Before we start, please entor your username now: ");
//string? answn = ReadLine();
//if(answn == unamel) WriteLine($"Welcome, {unamel}, please enter your chosen password: ");
///*else WriteLine("Wong! Again!");*/
//string? answp = ReadLine();
//if(answp == pw) WriteLine($"Nice to have you here, {unamel}!");

namespace challenge
    {
    class Program
        {
        static string? uname;
        static string? pw;
        static string? answn;
        static string? answp;
        static int strikes = 3;
        static void Main(string[] args)
            {
            Register();
            Login();
            WriteLine($"The show is over,{uname}. Goodbye!");
            ReadKey();
            }

        public static void Register()
            {
            WriteLine("Welcome!Please enter a user name:");
            uname = ReadLine();
            /*this part does not work!*/
            //if(uname == null)
            //    {
            //    WriteLine("U must enter something!");
            //    Clear();
            //    Register();
            //    }
            //else
            //    {
            WriteLine("Now, a password:");
            pw = ReadLine();
            /*this part does not work*/
            //if(pw == null)
            //    {
            //    WriteLine("U must enter password?");
            //    Clear();
            //    Register();
            //    }
            //}
            }
        public static void Login()
            {
            WriteLine("Thank you.\n Before we start, please entor your username now: ");
            answn = ReadLine();

            if(answn != uname)
                {
                WriteLine("Wrong username.Again.");
                Login();
                }

            while(strikes > 0)
                {
                WriteLine($"Welcome, {uname}, please enter your chosen password: ");
                answp = ReadLine();
                if(answp == pw)
                    {
                    WriteLine($"Nice to have you here, {uname}!");
                    strikes = 0;
                    break;
                    }
                else
                    {
                    strikes--;
                    WriteLine($"Wrong Password! {strikes} left!");
                    continue;
                    }
                }
            }
        }
    }
