namespace Coding.Exercise
    {
    public class Method
        {
        public static string LowUpper(string s)
            {
            string low = s.ToLower();
            string high = s.ToUpper();
            string back = low + high;
            return back;
            }
        public static void Count(string s)
            {
            Console.WriteLine($"The amount of characters is {s.Length}.");
            }
        // Place for your methods


        public static void Run()
            {
            // We encourage you to test your code with different strings,
            // but don't forget to put the default string back at the end of your testing.
            string s = "HeY ThErE !";

            /// Change nothing down here 
            s = LowUpper(s);
            Console.WriteLine(s);
            Count(s);

            }
        }
    }