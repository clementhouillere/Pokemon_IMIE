using Pokemon_IMIE.usercontrols;
using Pokemon_IMIE.ViewModel;
using Windows.UI.Xaml.Controls;

// Pour plus d'informations sur le modèle d'élément Page vierge, voir la page http://go.microsoft.com/fwlink/?LinkId=234238

namespace Pokemon_IMIE.Pages
{
    /// <summary>
    /// Une page vide peut être utilisée seule ou constituer une page de destination au sein d'un frame.
    /// </summary>
    public sealed partial class GameView : Page
    {

        private GameViewModel gameViewModel;

        public Pokedex Pokedex { get; set; }
        public Image Map { get; set; }
        public Grid SuccessMenu { get; set; }
        public MainButton MainButton { get; set; }
        public MainButton RetryButton { get; set; }

        public GameView()
        {
            this.InitializeComponent();
            this.Pokedex = this.pokedex;
            this.Map = this.map;
            this.SuccessMenu = this.success_menu;
            this.MainButton = this.mainButton;
            this.RetryButton = this.retryButton;
            this.gameViewModel = new GameViewModel(this);

        }
    }
}
