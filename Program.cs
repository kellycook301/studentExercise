using System;

namespace StudentExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercise Lists = new Exercise ("lists", "csharp");
            Exercise Dictionaries = new Exercise ("dictionaries", "csharp");
            Exercise DailyJournal = new Exercise ("dailyJournal", "javascript");
            Exercise Sets = new Exercise ("sets", "csharp");

            Cohort TwentyFive = new Cohort ("twentyFive");
            Cohort TwentySix = new Cohort ("twentySix");
            Cohort TwentySeven = new Cohort ("twentySeven");

            Student Kelly = new Student ("Kelly", "Cook", "kellycook301", twentySeven);
            Student Dougie = new Student ("Dougie", "Fresh", "thaMostIll", twentySix);
            Student Liam = new Student ("Liam", "Duffy", "liamduffy", twentyFive);
            Student Leanne = new Student ("Leanne", "Johsnon", "leannesunny", twentySix);
             
            Instructor Brenda = new Instructor ("Brenda", "Long", "brendalong", twentySix);
            Instructor Donnie = new Instructor ("Donnie", "Solo", "donnieSolo", twentyFive);
            Instructor BestGuy = new Instructor ("Best", "Guy", "bestGuySucks", twentySeven);

            Joe.AssignExercise (loops, Rachel);
        }
    }
}
