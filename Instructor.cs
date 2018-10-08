using System.Collections.Generic;

namespace Instructor {

    public class Instructor {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SlackHandle { get; set; }
        public int Cohort { get; set; }

        public List<Exercise> exercises = new List<Exercise>();

    }
}