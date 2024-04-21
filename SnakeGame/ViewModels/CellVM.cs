using SnakeGame.Models;

namespace SnakeGame.ViewModels
{
    /// <summary>
    /// Модель представления клетки поля
    /// </summary>
    internal class CellVM: BaseVM
    {
        public int Row { get; }
        public int Column { get; }
        private CellType _cellType = CellType.None;

        public CellType CellType
        {
            get { return _cellType; }
            set { _cellType = value; OnPropertyChanged(nameof(CellType)); }
        }
        public CellVM(int row, int column)
        {
            Row = row;
            Column = column;
        }

    }
}
