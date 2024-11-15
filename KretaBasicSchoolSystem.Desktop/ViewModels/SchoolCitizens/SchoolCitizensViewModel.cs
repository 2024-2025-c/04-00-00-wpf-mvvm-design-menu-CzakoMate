using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using KretaBasicSchoolSystem.Desktop.ViewModels.Base;

namespace KretaBasicSchoolSystem.Desktop.ViewModels.SchoolCitizens
{
    public partial class SchoolCitizensViewModel : BaseViewModel
    {
        private StudentViewModel _studentViewModel;
        private TeacherViewModel _teacherViewModel;

        public SchoolCitizensViewModel()
        {
            _currentSchoolCitizensChildView = new StudentViewModel();
            _studentViewModel = new StudentViewModel();
            _teacherViewModel = new TeacherViewModel();
        }

        public SchoolCitizensViewModel(StudentViewModel studentViewModel, TeacherViewModel teacherViewModel)
        {
            _studentViewModel = studentViewModel;
            _teacherViewModel = teacherViewModel;

            _currentSchoolCitizensChildView= new StudentViewModel();
        }

        [ObservableProperty]
        private BaseViewModel _currentSchoolCitizensChildView;

        [RelayCommand]
        public void ShowStudentView()
        {
            CurrentSchoolCitizensChildView = _studentViewModel;
        }
        [RelayCommand]
        public void ShowTeacherView()
        {
            CurrentSchoolCitizensChildView = _teacherViewModel;
        }
    }
}
