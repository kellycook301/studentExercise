using System;
using System.Collections.Generic;

namespace StudentExercises {
    class Program {
        static void Main (string[] args) {
            // create 4 or more exercises
            // Because I used a constructor on each class, I can list them this way. I personally like this more.
            Exercise Lists = new Exercise ("lists", "csharp");
            Exercise Dictionaries = new Exercise ("dictionaries", "csharp");
            Exercise DailyJournal = new Exercise ("dailyJournal", "javascript");
            Exercise Sets = new Exercise ("sets", "csharp");

            // create 3 or more cohorts
            Cohort TwentyFive = new Cohort ("twentyFive");
            Cohort TwentySix = new Cohort ("twentySix");
            Cohort TwentySeven = new Cohort ("twentySeven");

            // create 4 or more students and assign them to one of the cohorts
            Student Kelly = new Student ("Kelly", "Cook", "kellycook301", TwentySeven);
            Student Dougie = new Student ("Dougie", "Fresh", "thaMostIll", TwentySix);
            Student Liam = new Student ("Liam", "Duffy", "liamduffy", TwentyFive);
            Student Leanne = new Student ("Leanne", "Johsnon", "leannesunny", TwentySix);

            // Create 3 or more instructors and assign them to one of the cohorts.
            Instructor Donnie = new Instructor ("Donnie", "Solo", "donnieSolo", TwentyFive);
            Instructor Brenda = new Instructor ("Brenda", "Long", "brendalong", TwentySix);
            Instructor BestGuy = new Instructor ("Best", "Guy", "bestGuySucks", TwentySeven);

            // Have each instructor assign 2 exercises to each of the students.
            // In the Instructor class AssignExercise accepts the argument of Exercise and Student.
            // Here it is read as a sentence.
            // Instructor Donnie is assigning the exercise "Lists" to student Kelly.
            Donnie.AssignExercise (Lists, Kelly);
            Donnie.AssignExercise (Dictionaries, Dougie);
            Brenda.AssignExercise (DailyJournal, Liam);
            Brenda.AssignExercise (Sets, Leanne);
            BestGuy.AssignExercise (Lists, Leanne);
            BestGuy.AssignExercise (Dictionaries, Kelly);

            // Create a list of students. Add all of the student instances to it.
            List<Student> students = new List<Student> ();
            students.Add (Kelly);
            students.Add (Dougie);
            students.Add (Liam);
            students.Add (Leanne);

            // Create a list of exercises. Add all of the exercise instances to it.
            List<Exercise> exercises = new List<Exercise> ();
            exercises.Add (Lists);
            exercises.Add (Dictionaries);
            exercises.Add (DailyJournal);
            exercises.Add (Sets);

            // Create a list of instructors. Add all of the instructor instances to it.
            List<Instructor> instructors = new List<Instructor> ();
            instructors.Add (Brenda);
            instructors.Add (Donnie);
            instructors.Add (BestGuy);

            // Create a list of cohorts. Add all of the cohort instances to it.
            List<Cohort> cohorts = new List<Cohort> ();
            cohorts.Add (TwentyFive);
            cohorts.Add (TwentySix);
            cohorts.Add (TwentySeven);

            // Generate a report that displays which students are working on which exercises.
            foreach (Exercise ex in exercises) {
                List<string> assignedStudents = new List<string> ();

                foreach (Student stu in students) {
                    if (stu.Exercises.Contains (ex)) {
                        assignedStudents.Add (stu.FirstName);
                    }
                }
                Console.WriteLine ($"{ex.Name} is being worked on by {String.Join(", ", assignedStudents)}");
            }
        }
    }
}