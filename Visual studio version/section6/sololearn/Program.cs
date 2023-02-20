using static System.Console;

namespace Solo
    {
    public class Program
        {
        static void Main(string[] args)
            {
            tester();
            ReadKey();
            }
        public static void tester()
            {
            int bid = 0;
            int maxbid = 0;
            while(true)
                {
                WriteLine("Bitte gebot");
                try
                    {
                    bid = Convert.ToInt32(Console.ReadLine());
                    if(bid > maxbid)
                        {
                        maxbid = bid;
                        }
                    }
                catch
                    {
                    WriteLine("sheesh digga");
                    break;
                    }
                }
            Console.WriteLine("Sold: {0}",maxbid);
            }
        }
    }