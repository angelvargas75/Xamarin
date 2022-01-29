using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace App.MVVM.VistaModelo
{
    public class VMPatron : BaseViewModel
    {
        #region VARIABLES
        string _texto;
        #endregion

        #region CONSTRUCTOR
        public VMPatron(INavigation navigation)
        {
            Navigation = navigation;
        }
        #endregion

        #region OBJETOS
        public string Texto {
            get { return _texto; }
            set { SetValue(ref _texto, value); }
        }
        #endregion

        #region PROCESOS
        public async Task ProcesoAsincrono()
        {

        }

        public void ProcesoSimple()
        {

        }
        #endregion

        #region COMANDOS
        public ICommand ProcesoAsynCommand => new Command(async () => await ProcesoAsincrono());
        public ICommand ProcesoSimpleCommand => new Command(ProcesoSimple);
        #endregion
    }
}
