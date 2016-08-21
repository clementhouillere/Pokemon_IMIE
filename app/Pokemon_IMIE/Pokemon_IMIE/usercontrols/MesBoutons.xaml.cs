using App2.API;
using Pokemon_IMIE.Model;
using Pokemon_IMIE.Pages;
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
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace Pokemon_IMIE.usercontrols
{
    public sealed partial class MesBoutons : BaseUserControl
    {
        private FightView view;



        private Model.Pokemon pokemon;

        public Model.Pokemon Pokemon
        {
            get { return pokemon; }
            set
            {
                pokemon = value;
                base.OnPropertyChanged("Pokemon");
            }
        }

        public FightView View
        {
            get
            {
                return view;
            }

            set
            {
                view = value;
            }
        }

        public MesBoutons()
        {
            this.InitializeComponent();
            base.DataContext = this;
        }

        private void attaque1(object sender, RoutedEventArgs e)
        {
            this.attaque(0);
        }

        private void attaque2(object sender, RoutedEventArgs e)
        {
            this.attaque(1);
        }

        private void attaque3(object sender, RoutedEventArgs e)
        {
            this.attaque(2);
        }

        private void attaque4(object sender, RoutedEventArgs e)
        {
            this.attaque(3);
        }

        private async void attaque(int indexAttaque)
        {
            APIManager apiManager = new APIManager();
            Pokemon defenseur = this.view.Adversaire.Pokemon;
            AttaqueResult r = await apiManager.Attaque<AttaqueResult>(this.pokemon.Id, this.pokemon.Attaques[2].Id, defenseur.Id);
            defenseur.Hp = r.vieDuDefenseur;
            this.view.Adversaire.Pokemon = defenseur;
        }
    }
}
