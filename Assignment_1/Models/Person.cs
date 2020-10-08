namespace Assignment_1.Models
{
    public class Person
    {
        private string FirstName;
        private string LastName;
        private int ID;
        private string HairColor;
        private string EyeColor;
        private int Age;
        private double Weight;
        private int Height;

        public Person()
        {
        }

        public Person(string firstName, string lastName, int id, string hairColor, string eyeColor, int age, double weight, int height)
        {
            FirstName = firstName;
            LastName = lastName;
            ID = id;
            HairColor = hairColor;
            EyeColor = eyeColor;
            Age = age;
            Weight = weight;
            Height = height;
        }

        public string FirstName1
        {
            get => FirstName;
            set => FirstName = value;
        }

        public string LastName1
        {
            get => LastName;
            set => LastName = value;
        }

        public int Id
        {
            get => ID;
            set => ID = value;
        }

        public string HairColor1
        {
            get => HairColor;
            set => HairColor = value;
        }

        public string EyeColor1
        {
            get => EyeColor;
            set => EyeColor = value;
        }

        public int Age1
        {
            get => Age;
            set => Age = value;
        }

        public double Weight1
        {
            get => Weight;
            set => Weight = value;
        }

        public int Height1
        {
            get => Height;
            set => Height = value;
        }
    }
    
}