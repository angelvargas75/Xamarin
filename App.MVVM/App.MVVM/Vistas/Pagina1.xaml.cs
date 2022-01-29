using App.MVVM.VistaModelo;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App.MVVM.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Pagina1 : ContentPage
    {
        public Pagina1()
        {
            InitializeComponent();
            BindingContext = new VMPagina1(Navigation); //Binding: enlaza la vista con el controlador(VistaModelo)
        }
    }
}