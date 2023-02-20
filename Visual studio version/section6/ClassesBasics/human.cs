using static System.Console;

namespace ClassesBasics
    {
    class Human
        {
        //members variables
        //they now are pricate because they will never be seen from the outside
        private string firstName;
        private string lastName;
        private string eyeColor;
        private int age;


        //default constructor, empty
        public Human()
            {
            WriteLine("Constructor called.Object created");
            }

        //parameterized
        //constructor
        public Human(string firstName)
            {
            this.firstName = firstName;
            }
        public Human(string firstName,string lastName)
            {
            this.firstName = firstName;
            this.lastName = lastName;
            }
        public Human(string firstName,string lastName,string eyeColor)
            {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
            }
        public Human(string firstName,string lastName,string eyeColor,int age)
            {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
            this.age = age;
            }

        //member
        public void Introduce()
            {
            if(firstName != null && lastName != null && eyeColor != null && age != 0)
                {
                if(age == 1)
                    {
                    WriteLine($"Hello, my Name is {this.firstName} {this.lastName}.\n" +
                                $"My Eyes are {this.eyeColor} and I am {this.age} year old.");
                    }
                else
                    {
                    WriteLine($"Hello, my Name is {this.firstName} {this.lastName}.\n" +
        $"My Eyes are {this.eyeColor} and I am {this.age} years old.");
                    }
                }
            else if(firstName != null && lastName != null && eyeColor != null)
                {
                WriteLine($"Hello, my Name is {this.firstName} {this.lastName}.\n" +
                                $"My Eyes are {this.eyeColor}.");
                }
            else if(firstName != null && lastName != null)
                {
                WriteLine($"Hello, my Name is {this.firstName} {this.lastName}.");
                }

            else if(firstName != null)
                {
                WriteLine($"Hello, my Name is {this.firstName}.");
                }
            else
                {
                WriteLine("SumtingWong___");
                }
            }
        }
    }