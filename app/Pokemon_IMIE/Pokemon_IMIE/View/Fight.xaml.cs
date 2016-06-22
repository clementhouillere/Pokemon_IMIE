using App2.API;
using ClassLibrary;
using Pokemon_IMIE.Pages;
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
    public sealed partial class Fight : Page
    {
        public Fight()
        {
            this.InitializeComponent();
            this.DataContext = this;
            this.ItsStatus.PokemonName = "Carapuce";
            this.ItsStatus.PokemonLogo = "http://www.pokepedia.fr/images/thumb/c/cc/Carapuce-RFVF.png/250px-Carapuce-RFVF.png";
            this.ItsStatus.PokemonHp = 50;
            this.ItsStatus.PokemonMaxHp =100;

            this.MyStatus.PokemonName = "Bulbizarre";
            this.MyStatus.PokemonLogo = "http://www.pokepedia.fr/images/thumb/e/ef/Bulbizarre-RFVF.png/250px-Bulbizarre-RFVF.png";
            this.MyStatus.PokemonHp = 75;
            this.MyStatus.PokemonMaxHp = 100;

        }
    }
}
