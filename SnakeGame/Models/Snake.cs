using SnakeGame.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SnakeGame.Models
{
    internal class Snake
    {
        // Очередь из клеток змейки
        public Queue<CellVM> SnakeCells { get; } = new Queue<CellVM>();
        // Игровое поле
        private List<List<CellVM>> _cells;
        // "Голова" змейки
        private CellVM _start;
        // Метод создания еды
        private Action _generateFood;
        public Snake(List<List<CellVM>> cells, CellVM start, Action generateFood)
        {
            _cells = cells;
            _start = start;
            _start.CellType = CellType.Snake;
            SnakeCells.Enqueue(_start);
            _generateFood = generateFood;
        }
        public void Move(MoveDirection direction)
        {
            var leaderCell = SnakeCells.Last();
            int nextRow = leaderCell.Row;
            int nextColumn = leaderCell.Column;

            switch (direction)
            {
                case MoveDirection.Left:
                    nextColumn--;
                    break;
                case MoveDirection.Right:
                    nextColumn++;
                    break;
                case MoveDirection.Up:
                    nextRow--;
                    break;
                case MoveDirection.Down:
                    nextRow++;
                    break;
                default:
                    break;
            }
            try
            {
                var nextCell = _cells[nextRow][nextColumn];
                switch (nextCell.CellType)
                {
                    case CellType.None:
                        nextCell.CellType = CellType.Snake;
                        SnakeCells.Dequeue().CellType = CellType.None;
                        SnakeCells.Enqueue(nextCell);
                        break;
                    case CellType.Food:
                        nextCell.CellType = CellType.Snake;
                        SnakeCells.Enqueue(nextCell);
                        _generateFood?.Invoke();
                        break;
                    default:
                        throw _gameOverEx;
                }
            }
            catch(ArgumentOutOfRangeException) 
            {
                throw _gameOverEx;
            }
            
        }
        private Exception _gameOverEx = new Exception("You lost! Try again...");
    }
}
