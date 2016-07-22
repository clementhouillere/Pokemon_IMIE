using Pokemon_IMIE.Pages;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Input;

namespace Pokemon_IMIE.ViewModel
{
    class MainPageViewModel
    {
        private MainPageView mainPageView;

        public MainPageView MainPageView
        {
            get { return mainPageView; }
            set { mainPageView = value; }
        }

        public MainPageViewModel(MainPageView mainPageView)
        {
            this.mainPageView = mainPageView;
            this.init();
            this.Bind();
        }


        public void Bind()
        {
            this.MainPageView.PlayButton.Tapped += PlayButton_Tapped;
        }

        private void init()
        {
        }

        private void PlayButton_Tapped(object sender, TappedRoutedEventArgs e)
        {
            (Window.Current.Content as Windows.UI.Xaml.Controls.Frame).Navigate(typeof(CreateUserView));
        }
    }
}
