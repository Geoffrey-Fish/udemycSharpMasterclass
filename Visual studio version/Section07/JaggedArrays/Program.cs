using static System.Console;

namespace Section07
    {
    class Program
        {
        static void Main(string[] args)
            {
            //declare jaggedArrey---n-----only here insert number of nested arrays
            int[][] jaggedArray = new int[3][];
            //declaring the number of arrays to it
            jaggedArray[0] = new int[5];
            jaggedArray[1] = new int[3];
            jaggedArray[2] = new int[1];
            //give values to the arrays
            jaggedArray[0] = new int[] { 2,3,5,7,11 };
            jaggedArray[1] = new int[] { 1,2,3 };
            jaggedArray[2] = new int[] { 13,21 };

            //alternative way
            int[][] jaggedArray2 = new int[][]
                {
                    new int[]{ 2,3,5,7,11 },
                    new int[]{1,2,3 },
                    new int[]{13,21 }
                    };
            WriteLine($"show array number 5 {jaggedArray[0][2]}");

            for(int i = 0;i < jaggedArray2.Length;i++)
                {
                for(int j = 0;j < jaggedArray2[i].Length;j++)
                    {
                    WriteLine($" This is {jaggedArray2[i][j]}.\n ");
                    }
                }

            WriteLine("thats it");
            WriteLine(";;;;;;;;;;;;;;;;;;;");
            WriteLine("Now, a little challenge result:");
            Shenanigans.greetings();
            }
        }
    }