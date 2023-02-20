using static System.Console;

namespace ClassesBasics
    {
    class Box
        {
        // member variable
        //this is now private
        private int length = 3; //hard coded value, changebla not from outside
        private int height;
        //public int width; // not needed anymore because of Property Width
        private int volume;

        public Box(int length,int height,int width)
            {
            this.length = length;
            this.height = height;
            Width = width;
            }

        // this is now public changeble
        /// <summary>
        /// This here is the first version of get and set
        /// </summary>
        /// <param name="length"></param>
        /// <exception cref="Exception"></exception>
        public void SetLength(int length)
            {
            if(length < 0)
                {
                throw new Exception("Length should be higher than zero");
                }
            this.length = length;
            }

        // this is publicly accessible
        public int GetLength()
            {
            return this.length;
            }

        //This here is a PROPERTY- Properties are written CapitalFirst
        public int Height //no parentheses
            {
            get
                {
                return height;
                }
            set
                {
                if(value < 0)
                    {
                    height = -value;
                    }
                else
                    {
                    height = value;
                    }
                }
            }


        //this is a fasttrack version. type prop and doubletap
        // and the declaration as variable isnt needed anymore.
        public int Width { get; set; }
        // this is the same version as this here

        /*
         * public int Width
         * {
         * get
         * {
         * return width;
         * }
         * set
         * {
         * width = value;
         * }
         */


        // to make something acessible and at the same time inaccessible, use something like
        //public int GetVolume()
        //    {
        //    return this.length * this.height * this.Width;
        //    }

        public int Volume
            {
            get
                {
                return this.Width * this.Height * this.GetLength();
                }
            set
                {
                volume = value;
                }
            }

        public void DisplayInfo()
            {
            volume = length * height * Width;
            WriteLine($"Length is {length} and height is {height} and width is {Width} so the volume is {volume}.");
            }
        public void FrontSurface()
            {
            WriteLine($"{length} * {height} equals {length * height}");
            }
        /*--------------leave this alone------------*/
        }
    }
