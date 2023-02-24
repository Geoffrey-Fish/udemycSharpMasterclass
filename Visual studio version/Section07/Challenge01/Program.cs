using static System.Console;
/*Create an application that takes 2 input values.
Any input value (1st input)
Asks the data type of the input value. (2nd input)
It will print to the console the options like below to take input for the 2nd input value:
Press 1 for String
Press 2 for integer
Press 3 for Boolean*/
namespace section7
    {
    class Program
        {
        static void Main(string[] args)
            {
            bool exit = false;

            bool text = false;
            bool nums = false;
            bool really = false;

            int kindNum;
            string answer;
            bool test = false;
            //Endles fun ahead!
            while(exit == false)
                {
                //////////////////////
                ///Input area

                WriteLine("Welcome. Please enter something.");
                Write("==> ");
                string? input = ReadLine().ToLower().Trim();

                WriteLine("Now tell me, was your entry: \n" +
                    "1: A string?\n" +
                    "2: An Integer?\n" +
                    "3: A boolean?\n" +
                    "Please enter your guess, 1 to 3:");
                Write("==> ");
                string? kind = ReadLine();

                try
                    {
                    kindNum = Convert.ToInt32(kind);
                    }
                catch
                    {
                    WriteLine("That is not a number.");
                    }
                kindNum = Convert.ToInt32(kind);
                if(kindNum < 1 || kindNum > 3)
                    {
                    WriteLine("Please stay within 1 to 3!"); //Wonky how handle?
                    }
                //else
                //    {
                //    nums = true;
                //    }
                ///Input area End
                ////////////////////// 
                ///Validation area


                text = StringTest(input);
                try
                    {
                    int temp = Convert.ToInt32(input);
                    nums = true;
                    }
                catch
                    {
                    nums = false;
                    }
                really = input == "true" ? true : false;
                ///Validation Area End
                ////////////////////


                ///Output Area through Switch
                ///First, personell answer to the type
                //////////////////////////
                answer = text ? "Thats a String!" : nums ? "Thats an Integer!" : really ? "Thats a boolean!" : "That's Muffin.";
                ///Second, crosstest if guess was right
                switch(kindNum)
                    {
                    case 1:
                        test = text ? true : false;
                        break;
                    case 2:
                        test = nums ? true : false;
                        break;
                    case 3:
                        test = really ? true : false;
                        break;
                    default:
                        test = false;
                        WriteLine("Fatal errer- I guess?");
                        break;
                    }


                ///Textoutput and end
                WriteLine($"Your given Sample was {input}.\n " +
                    $"{answer}\n" +
                    $"You chose {kind}.\n" +
                    $" That was {test}.");

                WriteLine("Want to play another round?\n" +
                    "(Y)es\n " +
                    "(N)ay");
                string? end = ReadLine().ToLower().Trim();
                if(end == null)
                    {
                    WriteLine("dafuq");
                    }
                else if(end == "y")
                    {
                    continue;
                    }
                else if(end == "n")
                    {
                    WriteLine("Goodbye.");
                    exit = true;
                    }
                }
            }

        /*Function for letter testing*/
        public static bool StringTest(string x)
            {
            for(int i = 0;i < x.Length;i++)
                {
                if(Char.IsLetter(x,i))
                    {
                    continue;
                    }
                else
                    {
                    return false;
                    }
                }
            return true;
            }


        }
    }