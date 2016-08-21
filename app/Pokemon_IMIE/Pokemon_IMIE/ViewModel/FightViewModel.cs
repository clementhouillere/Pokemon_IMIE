using App2.API;
using Pokemon_IMIE.Model;
using Pokemon_IMIE.Pages;
using Pokemon_IMIE.usercontrols;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;

namespace Pokemon_IMIE.ViewModel
{
    public class FightViewModel
    {
        private FightView FightView;

        public FightViewModel(FightView fightView)
        {
            this.FightView = fightView;
            this.init();
            this.Bind();
        }
        
        public void Bind()
        {
            this.FightView.ReturnButton.Tapped += Button_Tapped;
        }

        public async void init()
        {
            APIManager apiManager = new APIManager();

            AttaqueResult r = await apiManager.Attaque<AttaqueResult>(10, 35, 11);
            List<Dresseur> l = await apiManager.GetFromAPI<List<Dresseur>>();

            Dresseur ondine = l[2];
            Dresseur regis = l[4];
            Model.Pokemon p = ondine.pokemons[0];
            Model.Pokemon p2 = regis.pokemons[0];

            this.FightView.ItsStatus.Pokemon = p;
            this.FightView.MyStatus.Pokemon = p2;
            this.FightView.MesBoutons.View = this.FightView;
            this.FightView.MesBoutons.Pokemon = p2;

        }
        private void Button_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (((MainButton)sender).Name.Equals("returnButton"))
            {

                (Window.Current.Content as Frame).Navigate(typeof(GameView));

            }
        }
    }
}
