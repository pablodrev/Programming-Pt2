using System;
using System.Collections.Generic;
using System.Configuration;

namespace SnakeGame.ViewModels
{
    internal class StartWindowVM : BaseVM
    {
        public RelayCommand NewGameCommand { get; }
        StartWindow _startWindow;
        private List<int> _bestScores;
        public List<int> BestScores
        {
            get { return _bestScores; }
            set { _bestScores = value; OnPropertyChanged(nameof(BestScores)); }
        }
        string _bestScoresPath;
        private int _size;
        

        public StartWindowVM(StartWindow startWindow)
        {
            _startWindow = startWindow;

            NewGameCommand = new RelayCommand(obj => 
            {
                MainWindow mainWindow = new MainWindow();
                _size = Convert.ToInt32(obj);
                mainWindow.DataContext = new MainWindowVM(mainWindow, _size, _size);
                mainWindow.Show();
                _startWindow.Close();
            });

            var appSettings = ConfigurationManager.AppSettings;
            _bestScoresPath = appSettings["bestScoresPath"];

            BestScores = Scores.ReadScoreFromFile(_bestScoresPath);
        }
    }
}
