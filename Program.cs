using System;
using System.Collections.Generic;

// Once you have defined all of your custom types, go to your Main() method in Program.cs and implement the following logic.



namespace Ch8_studentExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // Create 4, or more, exercises.
             Exercise exercise1 = new Exercise("Exercise 1", "JavaScript");
             Exercise exercise2 = new Exercise("Exercise 2", "GitHub workflow");
             Exercise exercise3 = new Exercise("Exercise 3", "React");
             Exercise exercise4 = new Exercise("Exercise 4", "C# .Net");

            // Create 3, or more, cohorts.
            Cohort Cohort29 = new Cohort();
            Cohort29.cohortName = "Day Cohort 29";
            Cohort Cohort30 = new Cohort();
            Cohort30.cohortName = "Day Cohort 30";
            Cohort Cohort31 = new Cohort();
            Cohort31.cohortName = "Day Cohort 31";


            // Create 4, or more, students and assign them to one of the cohorts.
            Student Dakota = new Student("Dakota", "Cookson", "@DakotaSlack", 29);
            Student Colleen = new Student("Colleen", "Woolsey", "@CMoney", 29);
            Student Russ = new Student("Russ", "Reiter", "@CodeBoss", 29);
            Cohort29.rosterOfStudents.Add(Dakota);
            Cohort29.rosterOfStudents.Add(Colleen);
            Cohort29.rosterOfStudents.Add(Russ);

            // Create 3, or more, instructors and assign them to one of the cohorts.
            Instructor Andy = new Instructor("Andy", "Collins", "@AskingaLot", 29);
            Instructor Leah = new Instructor("Leah", "Hoeffling", "@LeahGH", 29);
            Instructor Madi = new Instructor("Madi", "Peper", "@MissPeper", 29);
            Cohort29.rosterOfInstructors.Add(Andy);
            Cohort29.rosterOfInstructors.Add(Leah);
            Cohort29.rosterOfInstructors.Add(Madi);
            // Have each instructor assign 2 exercises to each of the students.
            Andy.AssignAnExercise(Dakota, exercise1);
            Andy.AssignAnExercise(Colleen, exercise2);
            Leah.AssignAnExercise(Russ, exercise2);
            Leah.AssignAnExercise(Colleen, exercise3);
            Madi.AssignAnExercise(Russ, exercise3);
            Madi.AssignAnExercise(Dakota, exercise4);


            Console.WriteLine(" ------- ");
        }
    }

}
