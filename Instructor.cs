
using System;


// You must define a type for representing an instructor in code.

// First name
// Last name
// Slack handle
// The instructor's cohort
// A method to assign an exercise to a student


namespace Ch8_studentExercises
{
    public class Instructor {
        public string FirstName {get;set;}
        public string LastName {get;set;}
        public string SlackHandle {get;set;}
        public int CohortName {get;set;}

        // A method to assign an exercise to a student
        //  public void AssignAnExercise(Cohort cohort, Exercise exercise) {
        //     foreach(Student student in cohort.StudentList) {
        //     student.ExerciseList.Add(exercise);
        //     // Console.WriteLine($"{FirstName} assigned {exercise.ExerciseName} to {student.FirstName} who is in {cohort.CohortName}");
        //     };

        public Instructor(string firstName, string lastName, string slackHandle, int cohortName )
        {
            FirstName = firstName;
            LastName = lastName;
            SlackHandle = slackHandle;
            CohortName = cohortName;
        }
    }

}