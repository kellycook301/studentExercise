using System.Collections.Generic;

namespace StudentExercises {

    public class Cohort {
        public string Name { get; set; }
        
        public List<Student> Students;
        public List<Instructor> Instructors;

        public Cohort (string name) {
            Name = name;
        }
    }
}