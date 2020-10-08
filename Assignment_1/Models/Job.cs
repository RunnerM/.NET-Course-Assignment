using System.Collections.Generic;

namespace Assignment_1.Models
{
    public class Job
    {
        private List<string> Jobs = new List<string>()
        {
            "Teacher",
            "Engineer",
            "Garbage Collector",
            "Shepherd",
            "Pilot",
            "Police Officer",
            "Pirate",
            "Fireman",
            "Astronaut",
            "Captain",
            "Soldier",
            "Pizza Chef",
            "Chef",
            "Janitor",
            "Factory Worker",
            "Chauffeur Waitress",
            "Ninja",
            "Doctor",
            "Nurse",
            "Chemist",
            "Caretaker",
            "Gardener",
            "Mascot",
            "Athlete",
        };

        public bool checkJob(string job)
        {
            job = job.ToLower();
            return Jobs.Contains(job);
        }

        public void AddJob(string job)
        {
            job = job.ToLower();
            Jobs.Add(job);
        }
    }
}