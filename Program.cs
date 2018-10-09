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

            Student Kelly = new Student ("Kelly", "Cook", "kellycook301", TwentySeven);
            Student Dougie = new Student ("Dougie", "Fresh", "thaMostIll", TwentySix);
            Student Liam = new Student ("Liam", "Duffy", "liamduffy", TwentyFive);
            Student Leanne = new Student ("Leanne", "Johsnon", "leannesunny", TwentySix);
             
            Instructor Brenda = new Instructor ("Brenda", "Long", "brendalong", TwentySix);
            Instructor Donnie = new Instructor ("Donnie", "Solo", "donnieSolo", TwentyFive);
            Instructor BestGuy = new Instructor ("Best", "Guy", "bestGuySucks", TwentySeven);

            Donnie.AssignExercise (Lists, Kelly);
        }
    }
}
