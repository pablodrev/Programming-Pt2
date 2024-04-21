using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SnakeGame.ViewModels
{
    /// <summary>
    /// Базовая модель представления
    /// </summary>
    public class BaseVM: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
