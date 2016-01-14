using Pokemon_IMIE.usercontrols;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;

// Pour plus d'informations sur le modèle d'élément Page vierge, voir la page http://go.microsoft.com/fwlink/?LinkId=234238

namespace Pokemon_IMIE.Pages
{
    /// <summary>
    /// Une page vide peut être utilisée seule ou constituer une page de destination au sein d'un frame.
    /// </summary>
    public sealed partial class Game : Page
    {
        private int x;
        private int y;
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
        
        public Game()
        {
            this.InitializeComponent();
            Window.Current.Content.KeyDown += move;
            x = 3;
            y = 4;
            
        }
        public MainButton RetryButton { get { return this.retry_button; } }

        public int X
        {
            get
            {
                return x;
            }

            set
            {
                x = value;
            }
        }

        public int Y
        {
            get
            {
                return y;
            }

            set
            {
                y = value;
            }
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
                case Windows.System.VirtualKey.Right:
                    if (tab[x, y + 1] != 1)
                    {
                        this.moveRight(width);
                        y += 1;
                    }
                    break;
                case Windows.System.VirtualKey.Q:
                case Windows.System.VirtualKey.Left:
                    if (tab[x, y - 1] != 1)
                    {
                        this.moveLeft(width);
                        y -= 1;
                    }
                    break;
                case Windows.System.VirtualKey.S:
                case Windows.System.VirtualKey.Down:
                    if (tab[x + 1, y] != 1)
                    {
                        this.moveDown(height);
                        x += 1;
                    }
                    break;
                case Windows.System.VirtualKey.Z:
                case Windows.System.VirtualKey.Up:
                    if (tab[x - 1, y] != 1)
                    {
                        this.moveUp(height);
                        x -= 1;
                    }
                    break;
                
                default:
                    break;
            }
        }


        private void moveUp(int height)
        {
            Canvas.SetTop(map, Canvas.GetTop(map) + height);
        }
        private void moveDown(int height)
        {
            Canvas.SetTop(map, Canvas.GetTop(map) - height);
        }
        private void moveLeft(int width)
        {
            Canvas.SetLeft(map, Canvas.GetLeft(map) + width);
        }
        private void moveRight(int width)
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

        private void game_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            if (!e.PreviousSize.Width.Equals(0) && !e.PreviousSize.Height.Equals(0))
            {
                int height = int.Parse((e.PreviousSize.Height - e.NewSize.Height).ToString());
                int width = int.Parse((e.PreviousSize.Width - e.NewSize.Width).ToString());
                moveRight(width/2);
                moveDown(height/2);
            }
        }
    }

    
}
