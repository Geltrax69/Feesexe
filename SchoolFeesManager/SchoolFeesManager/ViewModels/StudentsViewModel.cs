using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using SchoolFeesManager.Models;
using System.Collections.ObjectModel;
using System.Linq;

namespace SchoolFeesManager.ViewModels
{
    public partial class StudentsViewModel : ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<Student> _students;

        [ObservableProperty]
        private string _searchText;

        public StudentsViewModel()
        {
            Students = new ObservableCollection<Student>();
            // Demo Data
            Students.Add(new Student { FirstName = "Arav", LastName = "Sharma", ClassName = "X", Section = "A", StudentKey = "S2026001", Balance = 0 });
            Students.Add(new Student { FirstName = "Vihaan", LastName = "Verma", ClassName = "X", Section = "B", StudentKey = "S2026002", Balance = 5000 });
        }

        [RelayCommand]
        private void AddStudent()
        {
            // Navigate to AddStudentView
        }
    }
}
