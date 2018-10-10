using System;
using System.Collections.Generic;

namespace StudentExercises {

    public class Instructor {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SlackHandle { get; set; }
        public Cohort Cohort { get; set; }

        // Instructor constructor
        public Instructor (string firstName, string lastName, string slackHandle, Cohort cohort) {
            FirstName = firstName;
            LastName = lastName;
            SlackHandle = slackHandle;
            Cohort = cohort;
        }

        // method for assigning an exercise to a student. Will need to know what the hell
        // exercises and students are so they will be arguments for AssignExercise.
        // Remember. It is public VOID because nothing is being returned.
        public void AssignExercise (Exercise exercise, Student student) {
            student.Exercises.Add(exercise);
        }
    }
}