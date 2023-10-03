using CommunityToolkit.Mvvm.ComponentModel;
using MenuProject.ViewModels.Base;

namespace MenuProject.ViewModels
{
    public partial class MainWindowViewModel : BaseViewModel
    {
        [ObservableProperty]
        private BaseViewModel _childViewModel;

        [ObservableProperty]
        private string _statusBarText = "A program betölödött...";    
    }
}
