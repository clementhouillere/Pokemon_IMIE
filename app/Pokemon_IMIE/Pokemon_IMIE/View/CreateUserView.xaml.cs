using Pokemon_IMIE.usercontrols;
using Pokemon_IMIE.ViewModel;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// Pour plus d'informations sur le modèle d'élément Page vierge, voir la page http://go.microsoft.com/fwlink/?LinkId=234238

namespace Pokemon_IMIE.Pages
{
    /// <summary>
    /// Une page vide peut être utilisée seule ou constituer une page de destination au sein d'un frame.
    /// </summary>
    public sealed partial class CreateUserView : Page
    {

        private CreateUserViewModel createUserViewModel;

        public MainButton PlayButton { get; set; }

        public CreateUserView()
        {
            this.InitializeComponent();
            this.PlayButton = this.playButton;
            this.createUserViewModel = new CreateUserViewModel(this);
        }
    }
}
