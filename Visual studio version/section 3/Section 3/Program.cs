using static System.Console;
internal class Program
    {
    private static void Main(string[] args)
        {
        /*//old stuff here
         WriteLine("Hello ");
         WriteThat("Hoy boy");
         Read();
        */
        /*
        WriteLine("Enter first number: ");
        int num1 = Int32.Parse(Console.ReadLine());

        WriteLine("Enter second number: ");
        int num2 = Int32.Parse(Console.ReadLine());
        WriteLine("Enter third number: ");
        int num3 = Int32.Parse(Console.ReadLine());
        WriteLine("Enter fourth number: ");
        int num4 = Int32.Parse(Console.ReadLine());
        int sum1 = Add(num1,num2);
        int sum2 = Add(num3,num4);
        double sum3 = Multiply(sum1,sum2);
        WriteLine($"So listen up, Punk!\n" +
            $"{num1} + {num2} equals: {sum1},\n" +
            $"{num3} + {num4} equals: {sum2},\n" +
            $"and the multiplication of these values,\n" +
            $"{sum1} * {sum2},\n" +
            $"is equal to:\n" +
            $"{sum3}!");
        */
        /*
         *         string hans = "Hans";
        string peter = "Peter";
        string jens = "Jens";
        GreetName(hans);
        GreetName(peter);
        GreetName(jens);
        */
        /*
WriteLine("Let's divide by zero!");
WriteLine("Please enter some number");
string input1 = Console.ReadLine();
try
    {
    int num1 = Int32.Parse(input1);
    }
catch(FormatException)
    {
    WriteLine("Jepp, formatexception.");
    }
catch(OverflowException)
    {
    WriteLine("Nope, thats overflow");
    }
catch(ArgumentNullException)
    {
    WriteLine("Here we go with argument null");
    }
catch(Exception ex)
    {
    WriteLine($"So, this {ex} is an Exception Ex thingy like ");
    }

WriteLine("Now the second number: ");
string input = Console.ReadLine();
try
    {
    int num2 = Int32.Parse(input);
    }
catch(FormatException)
    {
    WriteLine("Jepp, formatexception.");
    }
catch(OverflowException)
    {
    WriteLine("Nope, thats overflow");
    }
catch(ArgumentNullException)
    {
    WriteLine("Here we go with argument null");
    }
catch(Exception ex)
    {
    WriteLine($"So, this {ex} is an Exception Ex thingy like ");
    }
*/
        /* why does this not work??
        WriteLine($"Let's divide {num1} / {num2} = ");
        try
            {
            double seeThat = num1 / num2;
            catch(FormatException)
            {
            WriteLine("dont divide by Zero!");
            }
        */


        // Programm stuff here 

        //Topic now: Operators

        int num1 = 5;
        int num2 = 10;
        int num3;

        //unary operators
        num3 = -num1;
        WriteLine($"num3 is {num3}.");

        bool isSunny = true;
        WriteLine("Is it sunny? {0}",!isSunny);
        Console.WriteLine("{}",num2++);
        Console.WriteLine("{}",num2++);










        ////////////////////////////////////////////////////
        //Main method bracket
        ///////////////////////////////////////////////////////
        }




    ////////////////////////////////////////////////////////////////////////////
    //Method stuff here

    public static int Add(int a,int b)
        { return a + b; }
    public static double Multiply(int a,int b)
        { return a * b; }
    public static void GreetName(string name)
        { WriteLine($"Hi,{name}, how is it hanging!"); }
    public static void WriteThat(string text)
        {
        WriteLine(text);
        }




    ///////////////////////////////
    ///Programm Bracket
    ///////////////////////////////
    }