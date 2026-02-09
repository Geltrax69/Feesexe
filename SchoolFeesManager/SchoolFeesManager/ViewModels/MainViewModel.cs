using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Windows.Controls;
using SchoolFeesManager.Views;

namespace SchoolFeesManager.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        private object _currentView;

        public MainViewModel()
        {
            // Default view
            CurrentView = new DashboardView();
        }

        [RelayCommand]
        private void Navigate(string destination)
        {
            switch (destination)
            {
                case "Dashboard":
                    CurrentView = new DashboardView();
                    break;
                case "Students":
                    CurrentView = new StudentListView();
                    break;
                case "Fees":
                    CurrentView = new FeesView();
                    break;
                case "Ledger":
                    CurrentView = new LedgerView();
                    break;
                case "Reports":
                    CurrentView = new ReportsView();
                    break;
                case "Settings":
                    CurrentView = new SettingsView();
                    break;
            }
        }
    }
}
