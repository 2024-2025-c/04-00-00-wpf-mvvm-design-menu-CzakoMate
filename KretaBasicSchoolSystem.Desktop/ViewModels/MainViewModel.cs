using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FontAwesome.Sharp;
using KretaBasicSchoolSystem.Desktop.ViewModels.Base;
using KretaBasicSchoolSystem.Desktop.ViewModels.ControlPanel;
using KretaBasicSchoolSystem.Desktop.ViewModels.SchoolCitizens;
using KretaBasicSchoolSystem.Desktop.ViewModels.SchoolClasses;
using KretaBasicSchoolSystem.Desktop.ViewModels.SchoolSubjects;
using KretaBasicSchoolSystem.Desktop.ViewModels.ShoolGrades;
using KretaBasicSchoolSystem.Desktop.ViewModels.RestaurantPromotions;

namespace KretaBasicSchoolSystem.Desktop.ViewModels
{
    public partial class MainViewModel : BaseViewModel
    {
        private ControlPanelViewModel _controlPanelViewModel;
        private SchoolCitizensViewModel _schoolCitizensViewModel;
        private SchoolClassesViewModel _schoolClassesViewModel;
        private SchoolSubjectsViewModel _schoolSubjectsViewModel;
        private SchoolGradesViewModel _schoolGradesViewModel;
        private RestaurantPromotionsViewModel _restaurantPromotionsViewModel;

        public MainViewModel()
        {
            _controlPanelViewModel = new ControlPanelViewModel();
            _schoolCitizensViewModel = new SchoolCitizensViewModel();
            _schoolClassesViewModel = new SchoolClassesViewModel();
            _schoolSubjectsViewModel = new SchoolSubjectsViewModel();
            _schoolGradesViewModel = new SchoolGradesViewModel();
            _restaurantPromotionsViewModel= new RestaurantPromotionsViewModel();
        }

        public MainViewModel(
            ControlPanelViewModel controlPanelViewModel,
            SchoolCitizensViewModel schoolCitizensViewModel,
            SchoolClassesViewModel schoolClassesViewModel,
            SchoolSubjectsViewModel schoolSubjectsViewModel,
            SchoolGradesViewModel schoolGradesViewModel,
            RestaurantPromotionsViewModel restaurantPromotionsViewModel
            )
        {
            _controlPanelViewModel = controlPanelViewModel;
            _schoolCitizensViewModel = schoolCitizensViewModel;
            _schoolClassesViewModel= schoolClassesViewModel;
            _schoolSubjectsViewModel=schoolSubjectsViewModel ;
            _schoolGradesViewModel= schoolGradesViewModel ;
            _restaurantPromotionsViewModel = restaurantPromotionsViewModel ;

            CurrentChildView = _controlPanelViewModel;
            ShowDashbord();
        }

        [ObservableProperty]
        private string _caption = string.Empty;

        [ObservableProperty]
        private IconChar _icon = new IconChar();

        [ObservableProperty]
        private BaseViewModel _currentChildView;

        [RelayCommand]
        public void ShowDashbord()
        {
            Caption = "Vezérlőpult";
            Icon=IconChar.SolarPanel;
            CurrentChildView = _controlPanelViewModel;
        }

        [RelayCommand]
        public void ShowSchoolCitizens()
        {
            Caption = "Iskolapolgárok";
            Icon = IconChar.UserGroup;
            CurrentChildView = _schoolCitizensViewModel;
        }
        //schoolClass menüpont meghívása
        [RelayCommand]
        public void ShowSchoolClasses()
        {
            Caption = "Osztályok";
            Icon = IconChar.Chalkboard;
            CurrentChildView= _schoolClassesViewModel;
        }
        //schoolSubjects menüpont meghívása
        [RelayCommand]
        public void ShowSchoolSubjects()
        {
            Caption = "Tantárgyak";
            Icon = IconChar.GraduationCap;
            CurrentChildView = _schoolSubjectsViewModel;

        }
        //schoolGrades menüpont meghívása
        [RelayCommand]
        public void ShowSchoolGrades()
        {
            Caption = "Osztályzatok";
            Icon = IconChar.FeatherPointed;
            CurrentChildView = _schoolGradesViewModel;
        }
        //RestaurantPromotions menüpont meghívása
        [RelayCommand]
        public void ShowRestaurantPromotions()
        {
            Caption = "Akciók";
            Icon = IconChar.Percent;
            CurrentChildView = _restaurantPromotionsViewModel;
        }
    }
}
