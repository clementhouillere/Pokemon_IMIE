﻿using Pokemon_IMIE.Classes;
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
    public sealed partial class Pokedex : UserControl
    {
        public Pokedex()
        {
            this.InitializeComponent();
            List<Pokemon> p = new List<Pokemon>();

            for (int i = 0; i < 30; i++)
            {
                p.Add(new Pokemon("Nom " + i));
            }

            this.pokemonList.ItemsSource = p;
            String test = ((Pokemon) this.pokemonList.Items[0]).Nom;
            this.pokemonName.Text = test;
        }

        private void pokemonList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Pokemon p = ((Pokemon)this.pokemonList.SelectedItem);

            this.pokemonName.Text = p.Nom;
        }
    }
}
