using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using KretaBasicSchoolSystem.Desktop.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KretaBasicSchoolSystem.Desktop.ViewModels.RestaurantPromotions
{
    public partial class RestaurantPromotionsViewModel: BaseViewModel
    {
        private CurrentPromotionsViewModel _currentPromotionsViewModel;
        private AddNewPromotionViewModel _addNewPromotionviewModel;
        private PreviousPromotionsViewModel _previousPromotionsviewModel;
        private EditCurrentPromotionsViewModel _editCurrentPromotionviewModel;
        private PromotionReportsViewModel _promotionreportsviewModel;

        public RestaurantPromotionsViewModel()
        {
            _currentRestaurantPromotionsChildView = new AddNewPromotionViewModel();
            _currentPromotionsViewModel = new CurrentPromotionsViewModel();
            _addNewPromotionviewModel = new AddNewPromotionViewModel();
            _previousPromotionsviewModel = new PreviousPromotionsViewModel();
            _editCurrentPromotionviewModel = new EditCurrentPromotionsViewModel();
            _promotionreportsviewModel = new PromotionReportsViewModel();
        }

        public RestaurantPromotionsViewModel(CurrentPromotionsViewModel currentPromotionsViewModel, AddNewPromotionViewModel addNewPromotionViewModel, PreviousPromotionsViewModel previousPromotionsViewModel, EditCurrentPromotionsViewModel editCurrentPromotionsViewModel, PromotionReportsViewModel promotionReportsViewModel)
        {
            _currentPromotionsViewModel = currentPromotionsViewModel;
            _addNewPromotionviewModel = addNewPromotionViewModel;
            _previousPromotionsviewModel= previousPromotionsViewModel;
            _editCurrentPromotionviewModel= editCurrentPromotionsViewModel;
            _promotionreportsviewModel= promotionReportsViewModel;

            _currentRestaurantPromotionsChildView = new AddNewPromotionViewModel();
        }

        [ObservableProperty]
        private BaseViewModel _currentRestaurantPromotionsChildView;

        [RelayCommand]
        public void ShowCurrentPromotionsView()
        {
            CurrentRestaurantPromotionsChildView = _currentPromotionsViewModel;
        }
        [RelayCommand]
        public void ShowAddNewPromotionView()
        {
            CurrentRestaurantPromotionsChildView = _addNewPromotionviewModel;
        }
        [RelayCommand]
        public void ShowPreviousPromotionsView()
        {
            CurrentRestaurantPromotionsChildView = _previousPromotionsviewModel;
        }
        [RelayCommand]
        public void ShowEditCurrentPromotionsView()
        {
            CurrentRestaurantPromotionsChildView = _editCurrentPromotionviewModel;
        }
        [RelayCommand]
        public void ShowPromotionReportsView() {
            CurrentRestaurantPromotionsChildView = _promotionreportsviewModel;
        }
    }
}
