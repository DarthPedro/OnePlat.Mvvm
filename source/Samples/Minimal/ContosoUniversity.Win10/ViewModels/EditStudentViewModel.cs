using ContosoUniversity.Helpers;
using System;

namespace ContosoUniversity.ViewModels
{
    public class EditStudentViewModel : StudentBaseViewModel
    {
        protected override void OnSave()
        {
            if (this.Student == null)
            {
                throw new ArgumentNullException("Student");
            }

            // save the updated student.
            int index = this.context.Students.IndexOf(this.Student);
            context.Students[index] = this.Student;

            FrameHelper.MainFrame.GoBack();
        }
    }
}
