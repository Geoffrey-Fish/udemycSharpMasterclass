using static System.Console;

namespace Section07
    {
    //Passing arrays as Parameters
    class Program
        {
        static void Main(string[] args)
            {
            //initialize Array
            int[] studentsGrades = new int[] { 15,13,7,23,4 };
            // Give Array to calculation function as parameter
            double averageResult = GetAverage(studentsGrades);
            WriteLine($"The Average is: {averageResult}.");
            WriteLine("-----Challengecontent:");
            int[] happiness = new int[] { 2,4,1,8,5 };

            WriteLine("Happiness before altering its values:");
            foreach(int h in happiness)
                {
                Write(h + " ");
                }
            WriteLine();
            WriteLine("Happiness after, same array:");
            happinessPlus(happiness);
            foreach(int hh in happiness)
                {
                Write(hh + " ");
                }
            WriteLine();
            WriteLine("Happiness after, new array: ");
            int[] happinessNew = happyNew(happiness);
            foreach(int hhh in happinessNew)
                {
                Write(hhh + " ");

                }
            WriteLine();
            WriteLine("---------\n" +
                "Thats it.");
            WriteLine("That's because Arrays are references \n" +
                "to the memory location.\n" +
            "So, every alternating interaction with an array\n" +
            "through a function changes the array itself!");

            }
        /// <summary>
        /// Gets the average score from a given array
        /// </summary>
        /// <param name="gradesArray">Array with scores as integers</param>
        /// <returns> A double number for the result</returns>
        static double GetAverage(int[] gradesArray)
            {
            int size = gradesArray.Length;
            double average;
            int sum = 0;
            for(int i = 0;i < size;i++)

                {
                sum += gradesArray[i];
                }
            average = (double)sum / size;
            return average;
            }

        /*Challenge: create an array of happiness in the main method and assign 5 values to it.
         * Create a method which has an array of type int as its parameter.
         * this method should increase the argument given by 2 for each entry.
         * call this method in the main method and use "happiness" as the argument.
         * Create a foreach loop in the main method to write all values onto the console.
         * */
        static int[] happyNew(int[] x)
            {
            //This verion returns a new array with new values
            int[] happyPlus = new int[x.Length];
            int size = x.Length;
            for(int i = 0;i < size;i++)
                {
                happyPlus[i] = x[i] + 2;
                }
            return happyPlus;
            }
        static int[] happinessPlus(int[] x)
            {
            //This version returns the same Array, therefore alternating its contents
            int size = x.Length;
            for(int j = 0;j < size;j++)
                {
                x[j] += 2;
                }
            return x;
            }

        }
    }
