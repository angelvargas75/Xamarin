using App.MVVM.VistaModelo;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App.MVVM.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Pagina2 : ContentPage
    {
        public Pagina2()
        {
            InitializeComponent();
            BindingContext = new VMPagina2(Navigation);     //Enlazamos el binding a la vista VMPagina2
        }
    }
}