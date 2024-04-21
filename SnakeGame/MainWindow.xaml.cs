using SnakeGame.ViewModels;
using System.Windows;
using System.Configuration;
using System;

namespace SnakeGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int snakeSpeed;
        public MainWindow()
        {

            InitializeComponent();
            DataContext = new MainWindowVM(this, 10, 10);
            
        }
    }
}
