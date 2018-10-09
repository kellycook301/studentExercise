using System;
using System.Collections.Generic;

namespace StudentExercises {

    public class Student {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SlackHandle { get; set; }
        // A student can only be assigned to one cohort
        public Cohort Cohort { get; set; }

        // one to many relationship. A student can take many exercises.
        public List<Exercise> Exercises = new List<Exercise> ();

        // student constructor
        public Student (string firstName, string lastName, string slackHandle, Cohort cohort)
        {
            FirstName = firstName;
            LastName = lastName;
            SlackHandle = slackHandle;
            Cohort = cohort;
        }
    }
}