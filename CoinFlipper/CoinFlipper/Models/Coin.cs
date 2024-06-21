using CoinFlipper.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;


namespace CoinFlipper.Models
{
    public class Coin
    {
        public string LadoEscolhido { get; set; }
        public string LadoSorteado { get; set; }

        public Coin()
        {
            
        }

        public ICommand JogarCommand { get; }


        public string Jogar()
        {
            Random rnd = new();
            int resultado = rnd.Next(2);

            if (resultado == 0)
            {
                LadoSorteado = "cara";
            }
            else
            {
                LadoSorteado = "coroa";
            }

            return LadoSorteado;
        }
    }
}
