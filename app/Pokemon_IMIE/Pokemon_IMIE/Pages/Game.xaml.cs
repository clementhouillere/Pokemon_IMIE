using Pokemon_IMIE.usercontrols;
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

// Pour plus d'informations sur le modèle d'élément Page vierge, voir la page http://go.microsoft.com/fwlink/?LinkId=234238

namespace Pokemon_IMIE.Pages
{
    /// <summary>
    /// Une page vide peut être utilisée seule ou constituer une page de destination au sein d'un frame.
    /// </summary>
    public sealed partial class Game : Page
    {
        private static int height = 25;
        private static int width = 30;
        public Game()
        {
            this.InitializeComponent();
            Window.Current.Content.KeyDown += move;
            
        }
        public MainButton RetryButton { get { return this.retry_button; } }

        private void move(object sender, KeyRoutedEventArgs e)
        {
            int size = 50;
            
            switch (e.Key)
            {
                case Windows.System.VirtualKey.Space:
                    break;
                case Windows.System.VirtualKey.D:
                    this.moveRight();
                    break;
                case Windows.System.VirtualKey.Q:
                    this.moveLeft();
                    break;
                case Windows.System.VirtualKey.S:
                    this.moveDown();
                    break;
                case Windows.System.VirtualKey.Z:
                    this.moveUp();
                    break;
                
                default:
                    break;
            }
        }


        private void moveUp()
        {
            Canvas.SetTop(map, Canvas.GetTop(map) + height);
        }
        private void moveDown()
        {
            Canvas.SetTop(map, Canvas.GetTop(map) - height);
        }
        private void moveLeft()
        {
            Canvas.SetLeft(map, Canvas.GetLeft(map) + width);
        }
        private void moveRight()
        {
            Canvas.SetLeft(map, Canvas.GetLeft(map) -width);
        }

        private void MainButton_Tapped(object sender, TappedRoutedEventArgs e)
        {
            MainButton success_button = (MainButton) sender;
            if(success_menu.Visibility.Equals(Visibility.Collapsed))
            {
                success_menu.Visibility = Visibility.Visible;
                success_button.Label = "< Retour";
            } else
            {
                success_menu.Visibility = Visibility.Collapsed;
                success_button.Label = "Succès >";
            }
        }
    }

    
}
