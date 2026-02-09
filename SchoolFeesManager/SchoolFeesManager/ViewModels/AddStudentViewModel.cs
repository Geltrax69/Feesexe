using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using SchoolFeesManager.Models;

namespace SchoolFeesManager.ViewModels
{
    public partial class AddStudentViewModel : ObservableObject
    {
        [ObservableProperty]
        private Student _newStudent;

        [ObservableProperty]
        private int _currentStep;

        public AddStudentViewModel()
        {
            NewStudent = new Student();
            CurrentStep = 0;
        }

        [RelayCommand]
        private void NextStep()
        {
            if (CurrentStep < 3)
                CurrentStep++;
        }

        [RelayCommand]
        private void PreviousStep()
        {
            if (CurrentStep > 0)
                CurrentStep--;
        }

        [RelayCommand]
        private void SaveStudent()
        {
            // Save logic here
        }
    }
}
