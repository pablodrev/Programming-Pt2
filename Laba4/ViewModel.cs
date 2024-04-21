using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Laba4
{
    public class RelayCommand : ICommand
    {
        private readonly Action<object> _execute;
        private readonly Predicate<object> _canExecute;

        public RelayCommand(Action<object> execute, Predicate<object> canExecute = null)
        {
            _execute = execute ?? throw new ArgumentNullException(nameof(execute));
            _canExecute = canExecute;
        }

        public bool CanExecute(object parameter)
        {
            return _canExecute == null || _canExecute(parameter);
        }

        public void Execute(object parameter)
        {
            _execute(parameter);
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public void RaiseCanExecuteChanged()
        {
            CommandManager.InvalidateRequerySuggested();
        }
    }




    public class ViewModel : INotifyPropertyChanged
    {

        ushort _nNumbers;
        public ushort nNumbers 
        { 
            get { return _nNumbers; }
            set { _nNumbers = value; OnPropertyChanged("nNumbers"); }
        }

        ushort _nCorrectNumbers;

        public ushort nCorrectNumbers
        {
            get { return _nCorrectNumbers; }
            set { _nCorrectNumbers = value; OnPropertyChanged("nCorrectNumbers"); }
        }

        public ObservableCollection<ushort> Numbers { get; set; }
        public ObservableCollection<ushort> CorrectNumbers { get; set; }

        public ViewModel()
        {
 
        }

        public ICommand NewGameCommand
        {
            get { return new RelayCommand(obj => NewGame()); }
        }
        private void NewGame()
        {
            GameModel game = new GameModel(nNumbers, nCorrectNumbers);
        }

        public ICommand GuessCommand
        {
            get { return new RelayCommand(obj => Guess()); }
        }
        private void Guess()
        {

        }



        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
