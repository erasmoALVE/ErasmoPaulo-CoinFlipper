using Microsoft.Maui.Controls;
using CoinFlipper.ViewModel;

namespace CoinFlipper.View
{
    public partial class CoinView : ContentPage
    {
        public CoinView()
        {
            InitializeComponent();
            BindingContext = new CoinViewModel();
        }
    }
}
