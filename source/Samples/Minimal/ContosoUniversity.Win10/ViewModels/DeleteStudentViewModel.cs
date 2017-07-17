using ContosoUniversity.Helpers;
using OnePlat.Mvvm.Core;
using System;
using System.Windows.Input;

namespace ContosoUniversity.ViewModels
{
    public class DeleteStudentViewModel : StudentBaseViewModel
    {
        public DeleteStudentViewModel()
            : base()
        {
            this.DeleteCommand = new DelegateCommand(p => this.OnDelete());
        }

        public ICommand DeleteCommand { get; set; }

        private void OnDelete()
        {
            if (this.Student == null)
            {
                throw new ArgumentNullException("Student");
            }

            this.context.Students.Remove(this.Student);
            FrameHelper.MainFrame.GoBack();
        }
    }
}
