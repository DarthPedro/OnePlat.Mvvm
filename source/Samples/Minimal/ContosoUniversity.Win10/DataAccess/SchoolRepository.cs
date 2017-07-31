using ContosoUniversity.Models;
using System.Collections.Generic;

namespace ContosoUniversity.DataAccess
{
    public class SchoolRepository
    {
        #region Singleton pattern
        private static readonly SchoolRepository current = new SchoolRepository();
        public static int studentNextId = 200;

        private SchoolRepository()
        {
            DataInitializer.Initialize(this);
        }

        public static SchoolRepository Current
        {
            get { return current; }
        }
        #endregion

        public IList<Student> Students { get; set; } = new List<Student>();

        public IList<Instructor> Instructors { get; set; } = new List<Instructor>();

        public IList<Department> Departments { get; set; } = new List<Department>();

        public IList<Course> Courses { get; set; } = new List<Course>();

        public IList<OfficeAssignment> OfficeAssignments { get; set; } = new List<OfficeAssignment>();

        public IList<CourseAssignment> CourseAssignments { get; set; } = new List<CourseAssignment>();

        public IList<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
    }
}
