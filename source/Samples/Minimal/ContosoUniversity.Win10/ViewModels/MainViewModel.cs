using ContosoUniversity.Helpers;
using ContosoUniversity.Views;
using OnePlat.Mvvm.Core;
using System.Windows.Input;

namespace ContosoUniversity.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {
            this.StudentsCommand = new DelegateCommand((p) => this.OnStudents());
        }

        public ICommand StudentsCommand { get; set; }

        private void OnStudents()
        {
            FrameHelper.MainFrame.Navigate(typeof(ListStudentsPage));
        }
    }
}
