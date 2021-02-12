using System;

namespace ContosoUniversity.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }

    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public Grade? Grade { get; set; }           //an enum: check above, ? meaning nullable
        public Course Course { get; set; }
        public Student Student { get; set; }
    }
}