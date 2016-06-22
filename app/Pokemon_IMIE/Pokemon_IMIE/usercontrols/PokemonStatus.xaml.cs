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
    public sealed partial class PokemonStatus : UserControl
    {

        public static readonly DependencyProperty PokemonNameProperty =
            DependencyProperty.Register("PokemonName", typeof(string), typeof(PokemonStatus), null);
        public static readonly DependencyProperty PokemonLogoProperty =
             DependencyProperty.Register("PokemonLogo", typeof(string), typeof(PokemonStatus), null);
        public static readonly DependencyProperty PokemonHpProperty =
             DependencyProperty.Register("PokemonHp", typeof(int), typeof(PokemonStatus), null);
        public static readonly DependencyProperty PokemonMaxHpProperty =
             DependencyProperty.Register("PokemonMaxHp", typeof(int), typeof(PokemonStatus), null);

        public PokemonStatus()
        {
            this.InitializeComponent();
            this.DataContext = this;
        }

        public String PokemonName
        {
            get { return (string)GetValue(PokemonNameProperty); }
            set { SetValue(PokemonNameProperty, value); }
        }
        public String PokemonLogo
        {
            get { return (string)GetValue(PokemonLogoProperty); }
            set { SetValue(PokemonLogoProperty, value); }
        }
        public int PokemonHp
        {
            get { return (int)GetValue(PokemonHpProperty); }
            set { SetValue(PokemonHpProperty, value); }
        }
        public int PokemonMaxHp
        {
            get { return (int)GetValue(PokemonMaxHpProperty); }
            set { SetValue(PokemonMaxHpProperty, value); }
        }
    }
}
