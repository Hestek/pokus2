using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace pokus2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    
    public partial class MainWindow : Window
    {
        int playersize = 25;
        Player player;

        public MainWindow()
        {
            InitializeComponent();
            player = new Player();
            player.Distance = 10;
            player.X = 50;
            player.Y = 50;
        }

        public void DrawApp()
        {
            canvas.Children.Clear();
            DrawPlayer(player);
        }


        public void DrawPlayer(Player player)
        {
            var rect = new Rectangle();
            rect.Height = playersize;
            rect.Width = playersize;
            rect.Fill = player.SelectedColor;
            Canvas.SetLeft(rect, player.X);
            Canvas.SetTop(rect, player.Y);
            canvas.Children.Add(rect);

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DrawApp();
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.Space:
                    player.SelectNextColor();
                    break;
                    case Key.Up:
                    player.Y = player.Y - player.Distance;
                    break;
                case Key.Down:
                    player.Y = player.Y + player.Distance;
                    break;
                case Key.Left:
                    player.X -= player.Distance;
                    break;
                case Key.Right:
                    player.X += player.Distance;
                    break;
            }
            DrawApp();
        }
    }
}
