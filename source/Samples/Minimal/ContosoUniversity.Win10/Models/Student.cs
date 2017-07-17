using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ContosoUniversity.Models
{
    public class Student : Person
    {
        private DateTime enrollmentDate;
        private ICollection<Enrollment> enrollments;

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Enrollment Date")]
        public DateTime EnrollmentDate
        {
            get { return this.enrollmentDate; }
            set { this.SetProperty<DateTime>(ref this.enrollmentDate, value); }
        }

        public ICollection<Enrollment> Enrollments
        {
            get { return this.enrollments; }
            set { this.SetProperty<ICollection<Enrollment>>(ref this.enrollments, value); }
        }
    }
}
