// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

using Pokemon_IMIE.Pages;
using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Input;

namespace Pokemon_IMIE.usercontrols
{
    public sealed partial class MainButton : BaseUserControl
    {
        public MainButton()
        {
            this.InitializeComponent();
            base.DataContext = this;
        }


        public String Label
        {
            get { return (string)base.GetValue(LabelProperty); }
            set { base.SetValue(LabelProperty, value); }
        }

        public static readonly DependencyProperty LabelProperty =
            DependencyProperty.Register("Label", typeof(string), typeof(MainButton), null);

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Tapped(object sender, TappedRoutedEventArgs e)
        { 
            Windows.UI.Xaml.Controls.Page p = ((Windows.UI.Xaml.Controls.Page)((Windows.UI.Xaml.Controls.Frame)Window.Current.Content).Content);
            switch (p.Name)
            {
                case "page1":
                    (Window.Current.Content as Windows.UI.Xaml.Controls.Frame).Navigate(typeof(CreateUser));
                    break;
                case "createUser":
                    (Window.Current.Content as Windows.UI.Xaml.Controls.Frame).Navigate(typeof(GameView));
                    break;
                case "game":
                    GameView g = ((GameView)p);
                    if (this == g.RetryButton)
                    {
                        (Window.Current.Content as Windows.UI.Xaml.Controls.Frame).Navigate(typeof(MainPage));
                    }

                    break;
            }
        }
    }
}
