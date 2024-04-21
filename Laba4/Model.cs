using System;
using System.Linq;

namespace Laba4
{
    public class GameModel
    {
        ushort[] _Numbers;
        ushort[] _CorrectNumbers;

        ushort[] Numbers { get; set; }
        ushort[] CorrectNumbers { get; set; }

        public GameModel(ushort nNumbers, ushort nCorrectNumbers)
        {
            // Создание диапазона чисел от 0 до заданного
            var numbersRange = Enumerable.Range(0, nNumbers).Select(x => (ushort)x);
            this.Numbers = numbersRange.ToArray();

            // Выбор правильных ответов случайным образом
            Random rand = new Random();
            this.CorrectNumbers = numbersRange.OrderBy(x => rand.Next()).Take(nCorrectNumbers).ToArray();
        }
    }
}

