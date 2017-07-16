using ContosoUniversity.DataAccess;
using ContosoUniversity.Helpers;
using ContosoUniversity.Models;
using OnePlat.Mvvm.Core;
using System;
using System.Windows.Input;

namespace ContosoUniversity.ViewModels
{
    public class CreateStudentViewModel : ViewModelBase
    {
        private SchoolRepository context;

        public CreateStudentViewModel()
        {
            this.context = SchoolRepository.Current;

            // initialize commands
            this.SaveCommand = new DelegateCommand(p => this.OnSave());
            this.CancelCommand = new DelegateCommand(p => this.OnCancel());
        }

        private Student newStudent = new Student();

        public Student NewStudent
        {
            get { return this.newStudent; }
            set { this.SetProperty<Student>(ref this.newStudent, value); }
        }

        private Nullable<DateTimeOffset> enrollmentDate;

        public Nullable<DateTimeOffset> EnrollmentDate
        {
            get { return this.enrollmentDate; }
            set { this.SetProperty<Nullable<DateTimeOffset>>(ref this.enrollmentDate, value); }
        }

        public ICommand SaveCommand { get; set; }
        
        private void OnSave()
        {
            // save the new student.
            this.NewStudent.EnrollmentDate = this.EnrollmentDate.Value.DateTime;
            context.Students.Add(this.NewStudent);

            FrameHelper.MainFrame.GoBack();
        }

        public ICommand CancelCommand { get; set; }

        private void OnCancel()
        {
            FrameHelper.MainFrame.GoBack();
        }
    }
}
