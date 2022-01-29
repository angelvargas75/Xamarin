using App.MVVM.Modelo;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace App.MVVM.VistaModelo
{
    public class VMPagina2 : BaseViewModel
    {
        #region VARIABLES
        string _texto;
        public List<MUsuarios> ListaUsuarios { get; set; }
        #endregion


        #region CONSTRUCTOR
        public VMPagina2(INavigation navigation)
        {
            Navigation = navigation;
            MostrarUsuarios();
        }
        #endregion


        #region OBJETOS
        public string Texto
        {
            get { return _texto; }
            set { SetValue(ref _texto, value); }
        }
        #endregion


        #region PROCESOS
        public async Task Volver()
        {
            await Navigation.PopAsync();
        }

        public void MostrarUsuarios()
        {
            ListaUsuarios = new List<MUsuarios>
            {
                new MUsuarios
                {
                    Nombre="Juan-mono",
                    Imagen="https://i.postimg.cc/nhCPzCc5/mono.png"
                },
                new MUsuarios
                {
                    Nombre="Mario-llama",
                    Imagen="https://i.postimg.cc/k4ccwmgK/llama.png"
                },
                new MUsuarios
                {
                    Nombre="Luis-leon",
                    Imagen="https://i.postimg.cc/fyRvrrVF/leon.png"
                }
            };
        }
        
        public async Task Alerta(MUsuarios parametro)
        {
            await DisplayAlert("Nombre", parametro.Nombre, "ok");
        }
        #endregion


        #region COMANDOS
        public ICommand VolverCommand => new Command(async () => await Volver());
        public ICommand ProcesoSimpleCommand => new Command(MostrarUsuarios);
        public ICommand AlertaCommand => new Command<MUsuarios>(async (p) => await Alerta(p));
        #endregion
    }
}
