using System.Collections.ObjectModel;
using System.Windows.Input;
using FABSample.MVVM;
using FABSample.Model;
using FABSample.Services;
using Xamarin.Forms;

namespace FABSample.ViewModel
{
    public class MainPageViewModel: BaseViewModel
    {
        private readonly IDialogService _dialogService;
        public ICommand AddCommand { get; private set; }

        public MainPageViewModel(IDialogService dialogService)
        {
            _dialogService = dialogService;

            Orders = new ObservableCollection<Order>();
            for (var i = 1; i < 50; i++)
            {
                var order = new Order() {OrderId = i.ToString(), OrderDescription = "This is order " + i, OrderType = "Service"};
                Orders.Add(order);
            }

            AddCommand = new Command(() =>
            {
                _dialogService.ShowMessage("Hello from FAB button", "ViewModel");
            });
        }

        private ObservableCollection<Order> _orders;
        public ObservableCollection<Order> Orders
        {
            get { return _orders; }
            set
            {
                if (_orders != value)
                {
                    _orders = value;
                    RaisePropertyChanged();
                }
            }
        }
    }
}
