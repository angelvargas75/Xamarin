using App.MVVM.Vistas;
using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace App.MVVM.VistaModelo
{
    public class VMPagina1 : BaseViewModel
    {
        #region VARIABLES
        string _N1;
        string _N2;
        string _R;
        string _TipoUsuario;
        DateTime _Fecha;
        string _FechaActual;
        string _ResultadoFecha;
        #endregion


        #region CONSTRUCTOR
        public VMPagina1(INavigation navigation)
        {
            Navigation = navigation;
            FechaActual = DateTime.Now.ToString("dd/MM/yyyy");
        }
        #endregion


        #region OBJETOS
        public string N1
        {
            get { return _N1; }
            set { SetValue(ref _N1, value); }
        }
        public string N2
        {
            get { return _N2; }
            set { SetValue(ref _N2, value); }
        }
        public string R
        {
            get { return _R; }
            set { SetValue(ref _R, value); }
        }
        public string TipoUsuario
        {
            get { return _TipoUsuario; }
            set { SetValue(ref _TipoUsuario, value); }
        }
        public string SeleccionarTipoUsuario
        {
            get { return _TipoUsuario; }
            set
            {
                SetProperty(ref _TipoUsuario, value);
                TipoUsuario = _TipoUsuario;
            }
        }
        public DateTime Fecha
        {
            get { return _Fecha; }
            set
            {
                _Fecha = value;
                OnpropertyChanged(Fecha.ToString());
                ResultadoFecha = Fecha.ToString("dd/MM/yyyy");
            }
        }
        public string FechaActual
        {
            get { return _FechaActual; }
            set { SetValue(ref _FechaActual, value); }
        }
        public string ResultadoFecha
        {
            get { return _ResultadoFecha; }
            set { SetValue(ref _ResultadoFecha, value); }
        }
        #endregion


        #region PROCESOS
        public async Task Volver()
        {
            await Navigation.PopAsync();
        }

        public async Task NavegarPagina2()
        {
            await Navigation.PushAsync(new Pagina2());
        }

        public void Sumar()
        {
            double n1 = 0;
            double n2 = 0;
            double respuesta = 0;
            n1 = Convert.ToDouble(N1);
            n2 = Convert.ToDouble(N2);
            respuesta = n1 + n2;
            R = respuesta.ToString();
        }
        #endregion


        #region COMANDOS
        public ICommand NavegarPagina2Command => new Command(async () => await NavegarPagina2());
        public ICommand SumarCommand => new Command(Sumar);
        public ICommand VolverCommand => new Command(async () => await Volver());
        #endregion
    }
}
