using static System.Console;

namespace Section07
    {
    class Shenanigans
        {
        public static void greetings()
            {
            string[][] fa = new string[][]
                {
                    new string[] { "Fritz","Inge" },
                    new string[] { "Gunther","Gerdi" },
                    new string[] { "Hans","Marie" }
                    };

            WriteLine("Welcome to the new threesome family gathering!");
            WriteLine();
            WriteLine($"{fa[0][0]}, {fa[0][1]}, this is {fa[1][0]} and {fa[1][1]}.\n" +
                $"{fa[2][0]}, {fa[2][1]}, this is {fa[0][0]} and {fa[0][1]}.\n" +
                $" {fa[1][0]}, {fa[1][1]}, this is {fa[2][0]} and {fa[2][1]}, as you might allready have guessed.");
            WriteLine("Now that everybody knows each other, let's eat!");
            //could also store allready made arrays in the jagged array.
            }
        }
    }

