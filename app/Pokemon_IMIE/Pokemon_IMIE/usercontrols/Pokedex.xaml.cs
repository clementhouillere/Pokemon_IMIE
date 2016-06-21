using ClassLibrary;
using System;
using System.Collections.Generic;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;

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
            pokemons.Add(new Pokemon("010", "Chenipan", "Un pokémon de type plante plutôt courant."));
            pokemons.Add(new Pokemon("011", "Chrisacier", "Un pokémon souvent inoffensif mais difficile à abbattre du fait de sa capacité armure."));
            pokemons.Add(new Pokemon("015", "Dardargnan", "Un pokémon poison."));
            pokemons.Add(new Pokemon("058", "Caninos", "Un petit chien de feu."));
            pokemons.Add(new Pokemon("059", "Arkanin", "Un magnifique pokémon feu, première évolution de Caninos."));
            pokemons.Add(new Pokemon("063", "Abra", "Le premier niveau d'un des pokémon PSY les plus puissant."));
            pokemons.Add(new Pokemon("069", "Chetiflor", "Un pokémon plante plutôt faible."));
            pokemons.Add(new Pokemon("070", "Boustiflor", "Un pokémon plante qui mange beaucoup."));
            pokemons.Add(new Pokemon("092", "Fantominus", "Un pokémon spectre qui évolue en spectrum."));
            pokemons.Add(new Pokemon("114", "Saquedeneux", "Ce pokémon est très discret."));
            pokemons.Add(new Pokemon("125", "Electek", "Un pokémon electrique très très rare."));
            pokemons.Add(new Pokemon("142", "Ptera", "Le pokémon dragon ancestrale"));
            pokemons.Add(new Pokemon("150", "Mewtow", "Le plus puissant des pokémons"));

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
            BitmapImage image = new BitmapImage(new Uri("ms-appx:/Assets/pokemons/" + p.Image, UriKind.Absolute));
            this.pokemonImage.Source = image;
            this.pokemonID.Text = p.Id;
            this.pokemonDescription.Text = p.Description;
        }
    }
}
