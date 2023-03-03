using static System.Console;

namespace Section07
    {
    class Program
        {
        static void Main(string[] args)
            {
            WriteLine();
            int iiin = 3;
            bool tru = true;
            char at = '@';
            float flo = 3.34f;
            string lol = "lol lol lol";
            //ParamsMethod takes a string and gives every item back, no matter how many items are given
            ParamsMethod("lol","this","is","so","funny","or","not");
            WriteLine("Now some objects: \n ");
            ParamsMethod2(iiin,tru,flo,lol,at);
            }
        //Thats possible because of the params keyword. It is like a wildcard for quantities
        public static void ParamsMethod(params string[] sentence)
            {
            for(int i = 0;i < sentence.Length;i++)
                {
                Write(sentence[i] + " ");
                }
            }
        public static void ParamsMethod2(params object[] stuff)
            {
            //for each loop to go through the array of objects
            foreach(object obj in stuff)
                {
                WriteLine(obj + "");
                }
            }

        }
    }