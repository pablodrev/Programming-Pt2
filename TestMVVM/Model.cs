using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;

namespace TestMVVM
{  
    public class GameModel : INotifyPropertyChanged
    {
        private INumberSelectionStrategy _strategy;
        public ObservableCollection<int> Numbers { get; set; }
        public ObservableCollection<int> CorrectNumbers { get; set; }
        public int GuessedCount { get; set; }

        public GameModel()
        {
            Numbers = new ObservableCollection<int>();
            CorrectNumbers = new ObservableCollection<int>();
            _strategy = new RandomSelection();
        }

        public void GenerateNumbers(int NNumbers, int NCorrectNumbers)
        {
            // Создание диапазона чисел от 1 до заданного
            var numbersRange = Enumerable.Range(1, NNumbers);
            Numbers = new ObservableCollection<int>(numbersRange);

            // Выбор правильных ответов случайным образом
            CorrectNumbers = _strategy.SelectNumbers(numbersRange, NCorrectNumbers);
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
