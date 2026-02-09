using System.Windows;
using SchoolFeesManager.ViewModels;

namespace SchoolFeesManager
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
        }
    }
}
