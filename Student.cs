
using System.Collections.Generic;


// You must define a type for representing a student in code. A student can only be in one cohort at a time. A student can be working on many exercises at a time.

// Properties
// First name
// Last name
// Slack handle
// The student's cohort
// The collection of exercises that the student is currently working on

namespace Ch8_studentExercises
{
    public class Student{
        public string FirstName {get ; set; }
        public string LastName {get; set; }
        public string SlackHandle {get; set;}
        public int Cohort {get; set;}

        public List <Exercise> ExerciseList {get; set;}

        public Student(string firstName, string lastName, string slackHandle, int Cohort) {
            FirstName = firstName;
            LastName = lastName;
            SlackHandle = slackHandle;
            ExerciseList = new List<Exercise>();
        }
    }

}