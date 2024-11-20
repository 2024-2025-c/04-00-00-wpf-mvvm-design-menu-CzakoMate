using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using KretaBasicSchoolSystem.Desktop.ViewModels.Base;
using KretaBasicSchoolSystem.Desktop.ViewModels.SchoolCitizens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KretaBasicSchoolSystem.Desktop.ViewModels.ShoolGrades
{
    public partial class SchoolGradesViewModel: BaseViewModel
    {
        private CurrentClassViewModel _currentClassViewModel;
        private TeachedClassesViewModel _teachedClassesViewModel;
        private SemesterClosingViewModel _semesterClosingViewModel;
        private EndOfYearClosingViewModel _endOfYearClosingViewModel;

        public SchoolGradesViewModel()
        {
            _currentSchoolGradesChildView = new CurrentClassViewModel();
            _currentClassViewModel = new CurrentClassViewModel();
            _teachedClassesViewModel= new TeachedClassesViewModel();
            _semesterClosingViewModel= new SemesterClosingViewModel();
            _endOfYearClosingViewModel= new EndOfYearClosingViewModel();
        }

        public SchoolGradesViewModel(CurrentClassViewModel currentClassViewModel, TeachedClassesViewModel teachedClassesViewModel, SemesterClosingViewModel semesterClosingViewModel, EndOfYearClosingViewModel endOfYearClosingViewModel)
        {
            _currentClassViewModel= currentClassViewModel;
            _teachedClassesViewModel = teachedClassesViewModel;
            _semesterClosingViewModel = semesterClosingViewModel;
            _endOfYearClosingViewModel= endOfYearClosingViewModel;

            _currentSchoolGradesChildView = new CurrentClassViewModel();
        }

        [ObservableProperty]
        private BaseViewModel _currentSchoolGradesChildView;

        [RelayCommand]
        public void ShowCurrentClassView()
        {
            CurrentSchoolGradesChildView = _currentClassViewModel;
        }
        [RelayCommand]
        public void ShowTeachedClassesView()
        {
            CurrentSchoolGradesChildView = _teachedClassesViewModel;
        }
        [RelayCommand]
        public void ShowSemesterClosingView()
        {
            CurrentSchoolGradesChildView = _semesterClosingViewModel;
        }
        [RelayCommand]
        public void ShowEndOfYearClosingView() {
            CurrentSchoolGradesChildView= _endOfYearClosingViewModel;
        }
    }
}
