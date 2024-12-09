using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Exa2DA_JAGS.VM
{
    internal class VMFreCar : BaseViewModel
    {
        #region VARIABLES
        int _cantidad;
        string _frecuencia;
        int _canfrecuencia;
        int _can;

        #endregion
        #region CONSTRUCTOR
        public VMFreCar(INavigation navigation)
        {
            Navigation = navigation;

        }
        #endregion
        #region OBJETOS
        public int Cantidad
        {
            get { return _cantidad; }
            set { SetValue(ref _cantidad, value); }
        }
        public string Frecuencia
        {
            get { return _frecuencia; }
            set { SetValue(ref _frecuencia, value); }
        }
        public int Canfrecuencia
        {
            get { return _can; }
            set { SetValue(ref _can, value); }
        }

        public int Can
        {
            get { return _canfrecuencia; }
            set { SetValue(ref _canfrecuencia, value); }
        }


        #endregion
        #region PROCESOS
        public async Task ProcesoAsyncrono()
        {

        }
        public void CalcularFrecuencia()
        {
            int Canfrecuencia = Cantidad * 4;
            if (Canfrecuencia <= 60)
            {
                Frecuencia = "Frecuencia Cardaquia baja";
            }
            else if (Canfrecuencia >= 100)
            {
                Frecuencia = "Frecuencia Cardaquia alta";
            }
            else
            {
                Frecuencia = "Frecuencia Cardaquia Normal";
            }
            Can = Canfrecuencia;
        }
        #endregion
        #region COMANDOS
        public ICommand ProcesoAsyncomand => new Command(async () => await ProcesoAsyncrono());
        public ICommand CalcularCommand => new Command(CalcularFrecuencia);
        #endregion
    }
}

