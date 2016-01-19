using Pokemon_IMIE.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace Pokemon_IMIE.usercontrols
{
    public sealed partial class Pokedex : UserControl
    {
        public Pokedex()
        {
            this.InitializeComponent();
            List<Pokemon> pokemons = new List<Pokemon>();

            pokemons.Add(new Pokemon("001", "Bulbizarre", "Un mini pokemon plante !"));
            pokemons.Add(new Pokemon("002", "Herbizarre", "Un moyen pokemon plante !"));
            pokemons.Add(new Pokemon("003", "Florizarre", "Un puissant pokemon plante !"));
            pokemons.Add(new Pokemon("004", "Salamèche", "Un mini pokemon feu !"));
            pokemons.Add(new Pokemon("005", "Reptincel", "Un moyen pokemon feu !"));
            pokemons.Add(new Pokemon("006", "Dracaufeu", "Un puissant pokemon feu !"));
            pokemons.Add(new Pokemon("007", "Carapuce", "Un mini pokemon eau !"));
            pokemons.Add(new Pokemon("008", "Carabaffe", "Un moyen pokemon eau !"));
            pokemons.Add(new Pokemon("009", "Tortank", "Un puissant pokemon eau !"));

            this.pokemonList.ItemsSource = pokemons;
            Pokemon firstPokemon = ((Pokemon) this.pokemonList.Items[0]);
            this.setDescriptionPanel(firstPokemon);
        }

        private void pokemonList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Pokemon p = ((Pokemon)this.pokemonList.SelectedItem);

            this.setDescriptionPanel(p);
        }

        private void setDescriptionPanel(Pokemon p)
        {
            this.pokemonName.Text = p.Name;
            BitmapImage image = new BitmapImage(new Uri("ms-appx:/Assets/" + p.Image, UriKind.Absolute));
            this.pokemonImage.Source = image;
            this.pokemonID.Text = p.Id;
            this.pokemonDescription.Text = p.Description;
        }
    }
}
