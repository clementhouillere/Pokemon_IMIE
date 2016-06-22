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
    class GameViewModel
    {
        private GameView gameView;


        private int x { get; set; }
        private int y { get; set; }
        private int[,] tab = new int[,]
        {
            { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
            { 1, 1, 1, 1, 1, 0, 1, 1, 1, 1, 1},
            { 0, 1, 1, 0, 0, 0, 0, 0, 1, 1, 0},
            { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
            { 1, 0, 1, 0, 0, 0, 0, 0, 1, 0, 1},
            { 1, 0, 1, 0, 0, 0, 0, 0, 1, 0, 1},
            { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
            { 0, 1, 1, 0, 0, 0, 0, 0, 1, 1, 0},
            { 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0}
        };

        public GameView GameView
        {
            get { return gameView; }
            set { gameView = value; }
        }

        public GameViewModel(GameView gameView)
        {
            this.gameView = gameView;
            this.init();
            this.Bind();
        }

        public void Bind()
        {
            this.GameView.SizeChanged += Game_SizeChanged;
            this.GameView.MainButton.Tapped += MainButton_Tapped;
        }

        private void init() {
            Window.Current.Content.KeyDown += move;
            x = 3;
            y = 4;
        }

        private void move(object sender, KeyRoutedEventArgs e)
        {
            int height = 32;
            int width = 32;
            switch (e.Key)
            {

                case Windows.System.VirtualKey.Space:
                    break;
                case Windows.System.VirtualKey.D:
                    if (tab[x, y + 1] != 1)
                    {
                        this.moveRight(width);
                        y += 1;
                    }
                    break;
                case Windows.System.VirtualKey.Q:
                    if (tab[x, y - 1] != 1)
                    {
                        this.moveLeft(width);
                        y -= 1;
                    }
                    break;
                case Windows.System.VirtualKey.S:
                    if (tab[x + 1, y] != 1)
                    {
                        this.moveDown(height);
                        x += 1;
                    }
                    break;
                case Windows.System.VirtualKey.Z:
                    if (tab[x - 1, y] != 1)
                    {
                        this.moveUp(height);
                        x -= 1;
                    }
                    break;
                case Windows.System.VirtualKey.H:

                    if (gameView.Pokedex.Visibility.Equals(Visibility.Collapsed))
                    {
                        gameView.Pokedex.Visibility = Visibility.Visible;
                    }
                    else
                    {
                        gameView.Pokedex.Visibility = Visibility.Collapsed;
                    }

                    break;

                default:
                    break;
            }
        }


        private void moveUp(int height)
        {
            Canvas.SetTop(gameView.Map, Canvas.GetTop(gameView.Map) + height);
        }
        private void moveDown(int height)
        {
            Canvas.SetTop(gameView.Map, Canvas.GetTop(gameView.Map) - height);
        }
        private void moveLeft(int width)
        {
            Canvas.SetLeft(gameView.Map, Canvas.GetLeft(gameView.Map) + width);
        }
        private void moveRight(int width)
        {
            Canvas.SetLeft(gameView.Map, Canvas.GetLeft(gameView.Map) - width);
        }

        private void MainButton_Tapped(object sender, TappedRoutedEventArgs e)
        {
            MainButton success_button = (MainButton)sender;
            if (gameView.SuccessMenu.Visibility.Equals(Visibility.Collapsed))
            {
                gameView.SuccessMenu.Visibility = Visibility.Visible;
                success_button.Label = "< Retour";
            }
            else
            {
                gameView.SuccessMenu.Visibility = Visibility.Collapsed;
                success_button.Label = "Succès >";
            }
        }

        private void Game_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            if (!e.PreviousSize.Width.Equals(0) && !e.PreviousSize.Height.Equals(0))
            {
                int height = int.Parse((e.PreviousSize.Height - e.NewSize.Height).ToString());
                int width = int.Parse((e.PreviousSize.Width - e.NewSize.Width).ToString());
                moveRight(width / 2);
                moveDown(height / 2);
            }
        }
    }
}
