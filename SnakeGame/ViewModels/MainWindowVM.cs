using SnakeGame.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Configuration;
using System.Diagnostics;

namespace SnakeGame.ViewModels
{
	internal class MainWindowVM: BaseVM
    {
		private bool _continueGame = false;

		public bool ContinueGame
		{
			get { return _continueGame; }
			private set 
			{	
				_continueGame = value; 
				OnPropertyChanged(nameof(ContinueGame));

				if (_continueGame) SnakeGo();
			}
		}

		// Таблица с клетками поля
		public List<List<CellVM>> Cells { get; } = new List<List<CellVM>>();
        public RelayCommand StartStopCommand { get; }
		private MoveDirection _currentMoveDirection = MoveDirection.Up;
		private int _rowCount;
		private int _columnCount;
        

		private int _speed;
		public int Speed 
		{
			get { return _speed; }
			set { _speed = value; }
		}
		public SpeedState SpeedState;

		private Snake _snake;
		private int _score;
		public int Score
		{
			get { return _score; }
			set { _score = value; OnPropertyChanged(nameof(Score)); }
		}

		private string _bestScorePath;
		private CellVM _lastFood;
		private MainWindow _mainWindow;

        public MainWindowVM(MainWindow mainWindow, int Rows, int Columns)
		{
			_mainWindow = mainWindow;
			StartStopCommand = new RelayCommand(o => { ContinueGame = !ContinueGame; });
			_rowCount = Rows;
			_columnCount = Columns;

			// Загрузка данных из конфигурационного файла
            var appSettings = ConfigurationManager.AppSettings;
            _speed = Convert.ToInt32(appSettings["snakeSpeed"]);
			_bestScorePath = appSettings["bestScoresPath"];

			// Заполнение поля клетками в нужном количестве
			for (int row = 0; row < _rowCount; row++)
			{
				var rowList = new List<CellVM>();
				for (int column = 0; column < _columnCount; column++)
				{
					var cell = new CellVM(row, column);
					rowList.Add(cell);
				}
				Cells.Add(rowList);
			}

			// Добавление змейки в центр поля
			_snake = new Snake(Cells, Cells[_rowCount / 2][_columnCount / 2], CreateFood);			
            _mainWindow.KeyDown += UserKeyDown;
			CreateFood();
			_score = 0;
			SpeedState = new NormalSpeedState();
        }

		// Изменяет направление движения в зависимости от нажатой клавиши
        private void UserKeyDown(object sender, KeyEventArgs e)
        {
            switch(e.Key)
			{
				case Key.A:
					if (_currentMoveDirection != MoveDirection.Right)
						_currentMoveDirection = MoveDirection.Left; 
					break;
                case Key.D:
                    if (_currentMoveDirection != MoveDirection.Left)
							_currentMoveDirection = MoveDirection.Right;
                    break;
                case Key.W:
                    if (_currentMoveDirection != MoveDirection.Down)
                        _currentMoveDirection = MoveDirection.Up;
                    break;
                case Key.S:
                    if (_currentMoveDirection != MoveDirection.Up)
                        _currentMoveDirection = MoveDirection.Down;
                    break;

            }
        }
		
		// Запуск змейки
        private async Task SnakeGo()
		{
			while (ContinueGame)
			{
				await Task.Delay(_speed);
				try
				{
					_snake.Move(_currentMoveDirection);
				}
				// Вызывается когда пользователь проиграл
				catch(Exception ex)
				{
					ContinueGame = false;
                    SaveBestScore();
                    MessageBox.Show(ex.Message, "Game Over", MessageBoxButton.OK, MessageBoxImage.Stop);

                    StartWindow startWindow = new StartWindow();
					startWindow.Show();

					_mainWindow.Close();
                }
			}
		}

		// Записать лучший результат
		private void SaveBestScore()
		{
			List<int> bestScores = new List<int>();
			bestScores = Scores.ReadScoreFromFile(_bestScorePath);
			int savePos = 0;
			// В зависимости от размера поля рекорд сохраняется в разные ячейки списка
			switch (_rowCount)
			{
				case 6:
					savePos = 2;
					break;
				case 8:
					savePos = 1;
					break;
				case 10:
					savePos = 0;
					break;
				default:
					break;
			}
			if (Score > bestScores[savePos])
			{
                bestScores[savePos] = Score;
                Scores.SaveScoreToFile(_bestScorePath, bestScores);
            }			
		}

		private void CreateFood()
		{
			var random = new Random();
			int row = random.Next(0, _rowCount);
			int column = random.Next(0, _columnCount);

			_lastFood = Cells[row][column];

			// Если еда создалась внутри змеи, то сгенерировать заново
			if (_snake.SnakeCells.Contains(_lastFood))
			{
				CreateFood();
			}
			Score++;

			if (Score > 5)
			{
				SpeedState.ChangeSpeedState(this);
			}

			_lastFood.CellType = CellType.Food;
			_speed = (int)(_speed * 0.95);		
		}
    }
}
