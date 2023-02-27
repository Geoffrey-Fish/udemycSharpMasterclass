using static System.Console;

namespace sector7
    {
    class Program
        {
        static void Main(string[] args)
            {
            int[] grades = new int[5];
            grades[0] = 20;
            grades[1] = 30;
            grades[2] = 3;
            grades[3] = 5;
            grades[4] = 6;

            WriteLine($"Grade on 3 is {grades[3]}");
            int[] nums = new int[10];
            WriteLine(" Arrays come in multiple dimensions. these are declared like that:");
            int[,] array2d = new int[,]
                {
                    { 1, 2,3 },
                    { 2, 3, 4 },
                    { 3, 4, 5 },
                    };

            WriteLine("This is the 2D array printed with a nested for loop");
            for(int i = 0;i < array2d.GetLength(0);i++)
                {
                for(int j = 0;j < array2d.GetLength(1);j++)
                    {
                    if(array2d[i,j] % 2 != 0)
                        {
                        WriteLine($"This is the odd number {array2d[i,j]}.");
                        }
                    if(i == j)
                        {
                        WriteLine($"PatternParty{array2d[i,j]}");
                        }
                    }
                }


            int[,,] array3d = new int[,,]
                {
                {
                    { 1, 2, 3 },
                    { 2, 3, 4 },
                    { 3, 4, 5 },
                },
                {
                    { 4, 5,6 },
                    { 5, 6,7 },
                    { 6, 7, 8 }
                }
            };

            }
        }
    }