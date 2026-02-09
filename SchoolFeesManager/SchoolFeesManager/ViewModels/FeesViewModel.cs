using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using SchoolFeesManager.Models;

namespace SchoolFeesManager.ViewModels
{
    public partial class FeesViewModel : ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<FeeStructure> _feeStructures;

        public FeesViewModel()
        {
            FeeStructures = new ObservableCollection<FeeStructure>();
            // Demo Data
            FeeStructures.Add(new FeeStructure { FeeName = "Tuition Fee", ClassName = "X", Amount = 2500, Frequency = "Monthly" });
            FeeStructures.Add(new FeeStructure { FeeName = "Annual Charges", ClassName = "X", Amount = 8000, Frequency = "Yearly" });
            FeeStructures.Add(new FeeStructure { FeeName = "Transport (Zone A)", ClassName = "All", Amount = 1200, Frequency = "Monthly", IsOptional = true });
        }
    }
}
