using KretaBasicSchoolSystem.Desktop.ViewModels;
using KretaBasicSchoolSystem.Desktop.ViewModels.ControlPanel;
using KretaBasicSchoolSystem.Desktop.ViewModels.Login;
using KretaBasicSchoolSystem.Desktop.ViewModels.SchoolCitizens;
using KretaBasicSchoolSystem.Desktop.ViewModels.SchoolClasses;
using KretaBasicSchoolSystem.Desktop.Views;
using KretaBasicSchoolSystem.Desktop.Views.ControlPanel;
using KretaBasicSchoolSystem.Desktop.Views.Login;
using KretaBasicSchoolSystem.Desktop.Views.SchoolCitizens;
using KretaBasicSchoolSystem.Desktop.Views.SchoolClasses;
using KretaBasicSchoolSystem.Desktop.Views.SchoolGrades;
using KretaBasicSchoolSystem.Desktop.Views.SchoolSubjects;
using Microsoft.Extensions.DependencyInjection;
using KretaBasicSchoolSystem.Desktop.ViewModels.ShoolGrades;
using KretaBasicSchoolSystem.Desktop.Views.SchoolGrades;
using KretaBasicSchoolSystem.Desktop.ViewModels.RestaurantPromotions;
using KretaBasicSchoolSystem.Desktop.Views.RestaurantPromotions;

namespace KretaDesktop.Extensions
{
    public static class ViewViewModelsExtensions
    {
        public static void ConfigureViewViewModels(this IServiceCollection services)
        {
            // MainView
            services.AddSingleton<MainViewModel>();
            services.AddSingleton<MainView>(s => new MainView()
            {
                DataContext = s.GetRequiredService<MainViewModel>()
            });

            // LoginView
            services.AddSingleton<LoginViewModel>();
            services.AddSingleton<LoginView>(s => new LoginView()
            {
                DataContext = s.GetRequiredService<LoginViewModel>()
            });

            // ControlPanel
            services.AddSingleton<ControlPanelViewModel>();
            services.AddSingleton<ControlPanelView>(s => new ControlPanelView()
            {
                DataContext = s.GetRequiredService<ControlPanelViewModel>()
            });
            // School Citizens
            services.AddSingleton<SchoolCitizensViewModel>();
            services.AddSingleton<SchoolCitizensView>(s => new SchoolCitizensView()
            {
                DataContext = s.GetRequiredService<SchoolCitizensViewModel>()
            });

            // Students
            // School Citizens
            services.AddSingleton<StudentViewModel>();
            services.AddSingleton<StudentView>(s => new StudentView()
            {
                DataContext = s.GetRequiredService<StudentViewModel>()
            });
            //Teachers
            services.AddSingleton<TeacherViewModel>();
            services.AddSingleton<TeacherView>(s => new TeacherView()
            {
                DataContext = s.GetRequiredService<TeacherViewModel>()
            });
            //ShcoolClass
            services.AddSingleton<SchoolClassesViewModel>();
            services.AddSingleton<SchoolClassesView>(
                s => new SchoolClassesView
                {
                    DataContext=s.GetRequiredService<SchoolClassesViewModel>()
                });
            //SchoolSubjects
            services.AddSingleton<SchoolSubjectsView>();
            services.AddSingleton<SchoolSubjectsView>(s => new SchoolSubjectsView()
            {
                DataContext = s.GetRequiredService<SchoolSubjectsView>()
            });
            //Parents
            // School Citizens
            services.AddSingleton<ParentViewModel>();
            services.AddSingleton<ParentView>(s => new ParentView()
            {
                DataContext = s.GetRequiredService<ParentView>()
            });
            // School Grades
            services.AddSingleton<SchoolGradesViewModel>();
            services.AddSingleton<SchoolGradesView>(s => new SchoolGradesView()
            {
                DataContext = s.GetRequiredService<SchoolGradesViewModel>()
            });
            // CurrentClass
            services.AddSingleton<CurrentClassViewModel>();
            services.AddSingleton<CurrentClassView>(s => new CurrentClassView()
            {
                DataContext = s.GetRequiredService<CurrentClassViewModel>()
            });
            //TeachedClasses
            services.AddSingleton<TeachedClassesViewModel>();
            services.AddSingleton<TeachedClassesView>(s => new TeachedClassesView()
            {
                DataContext = s.GetRequiredService<TeachedClassesViewModel>()
            });
            //SemesterClosing
            services.AddSingleton<SemesterClosingViewModel>();
            services.AddSingleton<SemesterClosingView>(s => new SemesterClosingView()
            {
                DataContext = s.GetRequiredService<SemesterClosingViewModel>()
            });
            //EndOfYearClosing
            services.AddSingleton<EndOfYearClosingViewModel>();
            services.AddSingleton<EndOfYearClosingView>(s => new EndOfYearClosingView()
            {
                DataContext = s.GetRequiredService<EndOfYearClosingViewModel>()
            });
            // Restaurant Promotions
            services.AddSingleton<RestaurantPromotionsViewModel>();
            services.AddSingleton<RestaurantPromotionsView>(s => new RestaurantPromotionsView()
            {
                DataContext = s.GetRequiredService<RestaurantPromotionsViewModel>()
            });
            //AddNewPromotion
            services.AddSingleton<AddNewPromotionViewModel>();
            services.AddSingleton<AddNewPromotionView>(s => new AddNewPromotionView()
            {
                DataContext = s.GetRequiredService<AddNewPromotionViewModel>()
            });
            //CurrentPromotions
            services.AddSingleton<CurrentPromotionsViewModel>();
            services.AddSingleton<CurrentPromotionsView>(s => new CurrentPromotionsView()
            {
                DataContext = s.GetRequiredService<CurrentPromotionsViewModel>()
            });
            //EditCurrentPromotions
            services.AddSingleton<EditCurrentPromotionsViewModel>();
            services.AddSingleton<EditCurrentPromotionsView>(s => new EditCurrentPromotionsView()
            {
                DataContext = s.GetRequiredService<EditCurrentPromotionsViewModel>()
            });
            //PreviousPromotions
            services.AddSingleton<PreviousPromotionsViewModel>();
            services.AddSingleton<PreviousPromotionsView>(s => new PreviousPromotionsView()
            {
                DataContext = s.GetRequiredService<PreviousPromotionsViewModel>()
            });
            //PromotionReports
            services.AddSingleton<PromotionReportsViewModel>();
            services.AddSingleton<PromotionReportsView>(s => new PromotionReportsView()
            {
                DataContext = s.GetRequiredService<PromotionReportsViewModel>()
            });
        }
    }
}
