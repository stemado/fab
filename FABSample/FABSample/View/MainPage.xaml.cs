using FABSample.Services;
using FABSample.ViewModel;
using Xamarin.Forms;

namespace FABSample.View
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainPageViewModel(new DialogService());
        }
    }
}
