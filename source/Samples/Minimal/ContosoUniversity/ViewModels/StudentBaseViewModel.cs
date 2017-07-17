using ContosoUniversity.DataAccess;
using ContosoUniversity.Helpers;
using ContosoUniversity.Models;
using OnePlat.Mvvm.Core;
using System;
using System.Linq;
using System.Windows.Input;

namespace ContosoUniversity.ViewModels
{
    public class StudentBaseViewModel : ViewModelBase
    {
        protected SchoolRepository context;

        public StudentBaseViewModel()
        {
            this.context = SchoolRepository.Current;

            // initialize commands
            this.SaveCommand = new DelegateCommand(p => this.OnSave());
            this.CancelCommand = new DelegateCommand(p => this.OnCancel());
        }

        public void InitializeStudent(int? studentId)
        {
            if (student != null)
            {
                this.Student = context.Students.First<Student>(s => s.ID == studentId);
                this.EnrollmentDate = this.Student.EnrollmentDate;
            }
        }

        private Student student = new Student();

        public Student Student
        {
            get { return this.student; }
            set { this.SetProperty<Student>(ref this.student, value); }
        }

        private Nullable<DateTimeOffset> enrollmentDate;

        public Nullable<DateTimeOffset> EnrollmentDate
        {
            get { return this.enrollmentDate; }
            set { this.SetProperty<Nullable<DateTimeOffset>>(ref this.enrollmentDate, value); }
        }

        public ICommand SaveCommand { get; set; }

        protected virtual void OnSave()
        {
        }

        public ICommand CancelCommand { get; set; }

        private void OnCancel()
        {
            FrameHelper.MainFrame.GoBack();
        }
    }
}
