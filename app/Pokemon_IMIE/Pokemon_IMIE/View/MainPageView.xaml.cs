using Pokemon_IMIE.ViewModel;
using Windows.UI.Xaml.Controls;

// Pour plus d'informations sur le modèle d'élément Page vierge, consultez la page http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Pokemon_IMIE.Pages
{
    /// <summary>
    /// Une page vide peut être utilisée seule ou constituer une page de destination au sein d'un frame.
    /// </summary>
    public sealed partial class MainPageView : Page
    {
        private MainPageViewModel mainPageViewModel;

        public MainPageView()
        {
            this.InitializeComponent();
            this.mainPageViewModel = new MainPageViewModel(this);
        }
    }
}
