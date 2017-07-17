using ContosoUniversity.DataAccess;
using ContosoUniversity.Helpers;
using System;

namespace ContosoUniversity.ViewModels
{
    public class CreateStudentViewModel : StudentBaseViewModel
    {
        protected override void OnSave()
        {
            if (this.Student == null)
            {
                throw new ArgumentNullException("Student");
            }

            // save the new student.
            this.Student.EnrollmentDate = this.EnrollmentDate.Value.DateTime;
            this.Student.ID = SchoolRepository.studentNextId++;
            context.Students.Add(this.Student);

            FrameHelper.MainFrame.GoBack();
        }
    }
}
