namespace Assignment_1.Models
{
    public class Adult : Person
    {
        private string Job;

        public Adult(string firstName, string lastName, int id, string hairColor, string eyeColor, int age, double weight, int height) : base(firstName, lastName, id, hairColor, eyeColor, age, weight, height)
        {
        }

        public Adult(string firstName, string lastName, int id, string hairColor, string eyeColor, int age, double weight, int height, string job) : base(firstName, lastName, id, hairColor, eyeColor, age, weight, height)
        {
            Job = job;
        }
    }
}