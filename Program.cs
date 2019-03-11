using System;
using System.Collections.Generic;

// Once you have defined all of your custom types, go to your Main() method in Program.cs and implement the following logic.

// Have each instructor assign 2 exercises to each of the students.


namespace Ch8_studentExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // Create 4, or more, exercises.
             Exercise exercise1 = new Exercise("Exercise 1", "JavaScript");

            // Create 3, or more, cohorts.
            Cohort Cohort29 = new Cohort();
            Cohort29.cohortName = "Day Cohort 29";

            // Create 4, or more, students and assign them to one of the cohorts.
            Student Dakota = new Student("Dakota", "Cookson", "@DakotaSlack", 29);
            // Dakota.Cohort= 29;
            Cohort29.rosterOfStudents.Add(Dakota);

            // Create 3, or more, instructors and assign them to one of the cohorts.
            Instructor Andy = new Instructor("Andy", "Collins", "@AskingaLot", 29);

        }
    }

}
