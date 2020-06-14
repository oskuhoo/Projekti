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
using Engine.Models.ViewModels;

namespace WPFUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private GameSession gameSession;

        public MainWindow()
        {
            InitializeComponent();

            gameSession = new GameSession();
            DataContext = gameSession;
        }

        private void OnClick_MoveUp(object sender, RoutedEventArgs e)
        {
            gameSession.MoveUp();
        }

        private void OnClick_MoveRight(object sender, RoutedEventArgs e)
        {
            gameSession.MoveRight();
        }

        private void OnClick_MoveDown(object sender, RoutedEventArgs e)
        {
            gameSession.MoveDown();
        }

        private void OnClick_MoveLeft(object sender, RoutedEventArgs e)
        {
            gameSession.MoveLeft();
        }

    }
}
