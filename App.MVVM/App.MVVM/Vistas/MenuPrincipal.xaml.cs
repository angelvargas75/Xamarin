using App.MVVM.VistaModelo;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App.MVVM.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPrincipal : ContentPage
    {
        public MenuPrincipal()
        {
            InitializeComponent();
            BindingContext = new VMMenuPrincipal(Navigation);
        }
    }
}