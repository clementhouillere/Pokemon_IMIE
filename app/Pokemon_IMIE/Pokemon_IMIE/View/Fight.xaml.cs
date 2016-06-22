using App2.API;
using ClassLibrary;
using Pokemon_IMIE.Model;
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
            

            init();
        }


        public async void init()
        {
            this.InitializeComponent();
            this.DataContext = this;
            APIManager apiManager = new APIManager();

            AttaqueResult r = await apiManager.Attaque<AttaqueResult>(10, 35, 11);
            List<Dresseur> l = await apiManager.GetFromAPI<List<Dresseur>>();

            Dresseur ondine = l[2];
            Dresseur regis = l[4];
            Model.Pokemon p = ondine.pokemons[0];
            Model.Pokemon p2 = regis.pokemons[0];
            this.ItsStatus.Pokemon = p;
            this.MyStatus.Pokemon = p2;
            this.MesBoutons.Pokemon = p2;

        }
    }
}
