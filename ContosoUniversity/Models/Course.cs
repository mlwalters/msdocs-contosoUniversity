using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}

// The Enrollments property is a navigation property. A Course entity can be related to any number of Enrollment entities.
// The DatabaseGenerated attribute is explained in a later tutorial. This attribute allows entering the PK for the course rather than having the database generate it.