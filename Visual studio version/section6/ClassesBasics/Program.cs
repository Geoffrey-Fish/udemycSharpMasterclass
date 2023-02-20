using static System.Console;


namespace ClassesBasics
    {
    class Program
        {
        static void Main(string[] args)
            {
            // create object of my class
            // an instance of human
            // now done with a constructor, it makes it way easier
            /*Human jeff = new Human();
            //access public variable from outside and even change it
            jeff.firstName = "Geoff";
            jeff.lastName = "Rey";
            jeff.Introduce();

            Human mike = new Human();
            mike.firstName = "klaus";
            mike.lastName = "Kinski";
            mike.Introduce();
            */
            /*
                        Human Fritz = new Human("Franz","Meiser","Braun",77);
                        Human Tim = new Human("Tom","Dummetut","Gelb",99);

                        Tim.Introduce();
                        Fritz.Introduce();

                        // now the basic default constructor
                        Human basicHuman = new Human();
                        basicHuman.Introduce();

                        Human Felix = new Human("Felix");
                        Felix.Introduce();

                        Human Hans = new Human("Hans","Meiser");
                        Hans.Introduce();

                        Human Maria = new Human("Maria","Vorwerk","Braun");
                        Maria.Introduce();

                        Human Paul = new Human("Paul","Panzer","Grün",44);
                        Paul.Introduce();
            

            //Box box = new Box();
            //// if i set this to minus it will throw an error
            //box.SetLength(8);
            //box.Width = 4;
            //box.Height = -8;

            Box box = new Box(8,7,2);
            box.DisplayInfo();
            WriteLine($"The length of the box is {box.GetLength()}.");
            //WriteLine($"Box Volume is {box.GetVolume()}");
            WriteLine($"Box width is {box.Width}");
            WriteLine($"Box Volume also could be asked by {box.Volume}.");
            box.SetLength(10);
            box.DisplayInfo();
            box.FrontSurface();

*/
            Members member1 = new Members();
            member1.Introducing(true);





            /*------------------just leave this below----------------*/

            ReadKey();
            }
        }
    }