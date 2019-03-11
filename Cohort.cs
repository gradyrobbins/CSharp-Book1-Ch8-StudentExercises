
using System.Collections.Generic;


// You must define a type for representing a cohort in code.

// The cohort's name (Evening Cohort 6, Day Cohort 25, etc.)
// The collection of students in the cohort.
// The collection of instructors in the cohort.

namespace Ch8_studentExercises
{
    public class Cohort {

        public string cohortName {get; set;}
        public List <Student> rosterOfStudents {get; set;}
        public List <Instructor> rosterOfInstructors {get; set;}

        public Cohort() {
        StudentRoster = new List<Student>();
        InstructorRoster= new List<Instructor>();
       }

    }

}