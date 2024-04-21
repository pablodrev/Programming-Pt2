using System;
using System.Linq;

namespace GuessTheNumber
{
    public class GameModel
    {
        ushort[] _Numbers;
        ushort[] _CorrectNumbers;

        ushort[] Numbers { get; set; }
        ushort[] CorrectNumbers { get; set; }
        
        public GameModel(ushort nNumbers, ushort nCorrectNumbers)
        {
            // �������� ��������� ����� �� 0 �� ���������
            var numbersRange = Enumerable.Range(0, nNumbers).Select(x => (ushort)x);
            this.Numbers = numbersRange.ToArray();

            // ����� ���������� ������� ��������� �������
            Random rand = new Random();
            this.CorrectNumbers = numbersRange.OrderBy(x => rand.Next()).Take(nCorrectNumbers).ToArray();
        }
    }
    public class GameViewModel
    {

    }
}
