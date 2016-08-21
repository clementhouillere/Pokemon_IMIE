using App2.API;
using ClassLibrary;
using Pokemon_IMIE.Model;
using Pokemon_IMIE.Pages;
using Pokemon_IMIE.usercontrols;
using Pokemon_IMIE.ViewModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Pour plus d'informations sur le modèle d'élément Page vierge, voir la page http://go.microsoft.com/fwlink/?LinkId=234238

namespace Pokemon_IMIE.Pages
{
    /// <summary>
    /// Une page vide peut être utilisée seule ou constituer une page de destination au sein d'un frame.
    /// </summary>
    public sealed partial class FightView : Page
    {

        private FightViewModel fightViewModel;

        public MainButton ReturnButton { get; set; }
        public PokemonStatus ItsStatus { get; set; }
        public PokemonStatus MyStatus { get; set; }
        public MesBoutons MesBoutons { get; set; }

        public FightView()
        {
            this.InitializeComponent();
            this.ReturnButton = this.returnButton;
            this.ItsStatus = this.itsStatus;
            this.MyStatus = this.myStatus;
            this.MesBoutons = this.mesBoutons;
            this.fightViewModel = new FightViewModel(this);

        }

        public PokemonStatus Adversaire
        {
            get
            {
                return this.ItsStatus;
            }
        }
        
    }
}
