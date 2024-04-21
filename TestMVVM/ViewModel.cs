using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;


namespace TestMVVM
{
    // Команда для создания кнопок с цифрами
    public class CreateButtonsCommand : ICommand
    {
        public GameViewModel vm;

        // Условия для выполнения команды
        public bool CanExecute(object parameter)
        {
            // Количество чисел не может быть меньше или равно количеству загаданных
            if (vm.NNumbers <= vm.NCorrectNumbers)
            {
                vm.NNumbers = 10;
                vm.NCorrectNumbers = 1;
                MessageBox.Show("Общее количество чисел должно быть больше количества загаданных чисел.", "Ошибка");                
                return false;
            }
            return true;
        }
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
        public void Execute(object parameter)
        {
            vm.NumbersButtons.Clear();
            vm.Log.Clear();
            vm.Game.GuessedCount = 0;

            vm.Game.GenerateNumbers(vm.NNumbers, vm.NCorrectNumbers);
            
            // Добавление кнопок с числами в коллекцию
            foreach (var number in vm.Game.Numbers)
            {
                Button btn = new Button();
                btn.Content = number.ToString();
                btn.FontSize = 14;
                btn.Click += vm.NumberButton_Click;
                vm.NumbersButtons.Add(btn);                
            }
        }        
    }

    // Модель представления
    public class GameViewModel : INotifyPropertyChanged
    {
        int _nNumbers;
        int _nCorrectNumbers;

        private GameModel game;

        public GameModel Game
        { 
            get { return game; }
            set { game = value; OnPropertyChanged("Game"); }        
        }
        // Коллекция с кнопками
        public ObservableCollection<Button> NumbersButtons { get; set; }
        // История ходов
        public ObservableCollection<int> Log { get; set; }

        ICommand createButtons;
        public ICommand CreateButtons
        {
            get { return createButtons; }
        }

        public int NNumbers 
        { 
            get { return _nNumbers; } 
            set {
                // Введенное число должно быть положительным
                    if (value <= 0)
                    {
                        MessageBox.Show("Количество чисел должно быть положительным", "Ошибка");
                        value = 10;
                    }
                    _nNumbers = value;
                    OnPropertyChanged("NNumbers");
                } 
        }
        public int NCorrectNumbers 
        { 
            get { return _nCorrectNumbers; } 
            set {
                // Введенное значение должно быть положительным
                    if (value <= 0)
                    {
                        MessageBox.Show("Количество загаданных чисел должно быть положительным", "Ошибка");
                        value = 1;
                    }
                    _nCorrectNumbers = value;
                    OnPropertyChanged("NCorrectNumbers");
                } 
        }

        public GameViewModel() 
        {
            _nNumbers = 10;
            _nCorrectNumbers = 1;
            createButtons = new CreateButtonsCommand { vm = this };
            NumbersButtons = new ObservableCollection<Button>();
            Game = new GameModel();
            Log = new ObservableCollection<int>();
        }

        public void NumberButton_Click(object sender, RoutedEventArgs e)
        {
            var btn = (Button)sender;
            int num = Convert.ToInt32(btn.Content);
            Log.Add(num);

            // Если пользователь нажал на правильную кнопку
            if (Game.CorrectNumbers.Contains(num))
            {
                Game.GuessedCount++;
                // Если пользователь угадал все числа
                if (NCorrectNumbers == Game.GuessedCount)
                {
                    MessageBox.Show("Вы угадали все загаданные цифры. Поздравляем!", "Конец игры");
                    NumbersButtons.Clear();
                    Game.Numbers.Clear();
                    Game.CorrectNumbers.Clear();
                    Log.Clear();
                    Game.GuessedCount = 0;
                }
                else
                {
                    MessageBox.Show("Цифра номер " + btn.Content + " правильная.", "Вы угадали число");
                }                
            }
            btn.IsEnabled = false;
        }


        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
