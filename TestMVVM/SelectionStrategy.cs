using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace TestMVVM
{
    public interface INumberSelectionStrategy
    {
        ObservableCollection<int> SelectNumbers(IEnumerable<int> numbers, int NCorrectNumbers);
    }
    // Выбирает правильные числа случайным образом
    public class RandomSelection : INumberSelectionStrategy
    {
        public ObservableCollection<int> SelectNumbers(IEnumerable<int> numbers, int NCorrectNumbers)
        {
            return new ObservableCollection<int>(numbers.OrderBy(x => new Random().Next()).Take(NCorrectNumbers));
        }
    }
    // Выбирает правильные числа подряд
    public class StraightSelection : INumberSelectionStrategy
    {
        public ObservableCollection<int> SelectNumbers(IEnumerable<int> numbers, int NCorrectNumbers)
        {
            ObservableCollection<int> correctNumbers = new ObservableCollection<int>();
            for (int i = 0; i < NCorrectNumbers; i++)
            {
                correctNumbers.Add(numbers.ElementAt(i));
            }
            return correctNumbers;
        }
    }
}
