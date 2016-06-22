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
            PokemonApi p1 = new PokemonApi();
            p1.Logo = "http://assets.pokemon.com/assets/cms2/img/pokedex/full//007.png";
            p1.Name = "Carapuce";
            p1.Hp = 50;
            p1.MaxHp = 100;
            this.ItsStatus.Pokemon = p1;

            PokemonApi p2 = new PokemonApi();
            p2.Logo = "http://assets.pokemon.com/assets/cms2/img/pokedex/full//001.png";
            p2.Name = "Bulbizarre";
            p2.Hp = 75;
            p2.MaxHp = 100;
            this.MyStatus.Pokemon = p2;
        }
    }
}
