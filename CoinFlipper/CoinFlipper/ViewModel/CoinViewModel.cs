using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoinFlipper.Models;
using System.Windows.Input;



namespace CoinFlipper.ViewModel
{
    public partial class CoinViewModel: ObservableObject
    {
        [ObservableProperty]
        private string resultadoMoeda;

        [ObservableProperty]
        private string fotoMoeda;

        [ObservableProperty]
        private string selecioneUmaMoeda;

        public ICommand JogarCommandMoeda { get; }

        public CoinViewModel()
        {
            JogarCommandMoeda = new RelayCommand(Jogar);
        }

        public void Jogar()
        {
            if (String.IsNullOrEmpty(selecioneUmaMoeda))
            {
                App.Current.MainPage.DisplayAlert("Cara ou coroa", "Selecione cara ou coroa para prosseguir", "ok");
            }
            else
            {
                Coin coin = new Coin();
                coin.Jogar();

                if (selecioneUmaMoeda == coin.LadoSorteado)
                {
                    resultadoMoeda = "Parabéns, você acertou";
                }
                else
                {
                    resultadoMoeda = "Você perdeu";
                }

                if (coin.LadoSorteado == "cara")
                {
                    fotoMoeda = "cara.png";
                }
                else
                {
                    fotoMoeda = "coroa.png";
                }
            }
        }
    }
}
