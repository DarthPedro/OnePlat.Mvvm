using ContosoUniversity.DataAccess;
using ContosoUniversity.Helpers;
using ContosoUniversity.Models;
using ContosoUniversity.Views;
using OnePlat.Mvvm.Core;
using System.Collections.Generic;
using System.Windows.Input;

namespace ContosoUniversity.ViewModels
{
    public class ListStudentsViewModel : ViewModelBase
    {
        private SchoolRepository context;

        public ListStudentsViewModel()
        {
            this.context = new SchoolRepository();
            this.Students = context.Students;

            // initialize commands
            this.CreateStudentCommand = new DelegateCommand((p) => this.OnCreateStudent());
            this.DetailsStudentCommand = new DelegateCommand((p) => this.OnDetailsStudent(),
                                                             p => { return this.CurrentStudent != null; });
            this.EditStudentCommand = new DelegateCommand((p) => this.OnEditStudent(),
                                                          p => { return this.CurrentStudent != null; });
            this.DeleteStudentCommand = new DelegateCommand((p) => this.OnDeleteStudent(),
                                                            p => { return this.CurrentStudent != null; });
        }

        private IList<Student> students;
        public IList<Student> Students
        {
            get { return this.students; }
            set { this.SetProperty<IList<Student>>(ref this.students, value); }
        }

        private Student currentStudent;
        public Student CurrentStudent
        {
            get { return this.currentStudent; }
            set { this.SetProperty<Student>(ref this.currentStudent, value, onChanged: this.UpdateCommands); }
        }

        public ICommand CreateStudentCommand { get; set; }

        private void OnCreateStudent()
        {
            FrameHelper.MainFrame.Navigate(typeof(CreateStudentPage));
        }

        public ICommand DetailsStudentCommand { get; set; }

        private void OnDetailsStudent()
        {
            FrameHelper.MainFrame.Navigate(typeof(DetailsStudentPage));
        }

        public ICommand EditStudentCommand { get; set; }

        private void OnEditStudent()
        {
            FrameHelper.MainFrame.Navigate(typeof(EditStudentPage));
        }

        public ICommand DeleteStudentCommand { get; set; }

        private void OnDeleteStudent()
        {
            FrameHelper.MainFrame.Navigate(typeof(DeleteStudentPage));
        }

        private void UpdateCommands()
        {
            ((DelegateCommand)CreateStudentCommand).RaiseCanExecuteChanged();
            ((DelegateCommand)DetailsStudentCommand).RaiseCanExecuteChanged();
            ((DelegateCommand)EditStudentCommand).RaiseCanExecuteChanged();
            ((DelegateCommand)DeleteStudentCommand).RaiseCanExecuteChanged();
        }
    }
}
