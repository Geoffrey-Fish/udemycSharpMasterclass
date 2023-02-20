using static System.Console;

namespace ClassesBasics
    {
    class Members
        {
        // member-private field
        private string memberName;
        private string jobTitle;
        private int salary;
        //member - public field
        public int age;

        public string JobTitle
            {
            get
                {
                return jobTitle;
                }
            set
                {
                jobTitle = value;
                }
            }
        //public member method-can be called from other members
        public void Introducing(bool isFriend)
            {
            if(isFriend)
                {
                SharingPrivateInfo();
                }
            else
                {
                WriteLine($"Hi, my name is {memberName}, I am a {jobTitle}, my age is {age}.");
                }
            }
        private void SharingPrivateInfo()
            {
            WriteLine($"My Salary is {salary}.");
            }
        //member constructor
        public Members()
            {
            age = 39;
            memberName = "botti";
            salary = 50000;
            jobTitle = "DevOps";
            WriteLine("Object created");
            }

        //member - finalizer - destructor
        // the tilde is the signal for a finalizer
        ~Members()
            {
            // cleanup statements
            WriteLine("Deconstruction of Members object");

            }



        }
    }
