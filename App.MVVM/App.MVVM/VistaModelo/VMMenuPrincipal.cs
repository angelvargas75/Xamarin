using App.MVVM.Vistas;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using MMenuPrincipal = App.MVVM.Modelo.MMenuPrincipal;

namespace App.MVVM.VistaModelo
{
    public class VMMenuPrincipal : BaseViewModel
    {
        #region VARIABLES
        string _texto;
        public List<MMenuPrincipal> ListaPaginas { get; set; }
        #endregion


        #region CONSTRUCTOR
        public VMMenuPrincipal(INavigation navigation)
        {
            Navigation = navigation;
            MostrarPaginas();
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

        public void MostrarPaginas()
        {
            ListaPaginas = new List<MMenuPrincipal>
            {
                new MMenuPrincipal
                {
                    Pagina="Entry, DatePicker, Picker, Label, Navigation",
                    Icono="https://i.postimg.cc/XJRL8Rhg/vistas.png"
                },
                new MMenuPrincipal
                {
                    Pagina="CollectionView sin enlace a base de datos",
                    Icono="https://i.postimg.cc/XJRL8Rhg/vistas.png"
                },
                new MMenuPrincipal
                {
                    Pagina="CRUD Pokemon",
                    Icono="https://i.postimg.cc/Dzqw0Lhy/pokebola.png"
                }
            };
        }

        public async Task Navegar(MMenuPrincipal parametro)
        {
            string pagina;
            pagina = parametro.Pagina;
            if (pagina.Contains("Entry, DatePicker"))
                await Navigation.PushAsync(new Pagina1());
            if (pagina.Contains("CollectionView sin enlace"))
                await Navigation.PushAsync(new Pagina2());
            if (pagina.Contains("CRUD Pokemon"))
                await Navigation.PushAsync(new CrudPokemon());
        }
        #endregion


        #region COMANDOS
        public ICommand NavegarCommand => new Command<MMenuPrincipal>(async (p) => await Navegar(p));
        #endregion
    }
}
