using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    // Тип данный Сессия с двумя возмодными значениями
    public enum Session
    {
        Summer,
        Winter
    }
    // Класс студент
    public class Student
    {
        private string _fullName; // ФИО
        private string _major; // Направление
        private int _year; // Год поступления
        private int _course; // Курс

        // Публичные переменные с проверкой данных
        public string FullName
        {
            get { return _fullName; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _fullName = value;
                else
                    throw new EmptyStringException("Введите непустое ФИО");
            }
        }
        public string Major
        {
            get { return _major; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _major = value;
                else
                    throw new EmptyStringException("Направление введено неверно");
            }
        }
        public int Year
        {
            get { return _year; }
            set
            {
                if (value > 0)
                    _year = value;
                else
                    throw new WrongYearException("Год должен быть положительным");
            }
        }
        public int Course
        {
            get { return _course; }
            set
            {
                if (1 <= value & value <= 4)
                    _course = value;
                else
                    throw new WrongCourseException("Курс должен быть от 1 до 4 включительно");
            }
        }

        public Student(string fullName, string major, int admissionYear, int course)
        {
            this.FullName = fullName;
            this.Major = major;
            this.Year = admissionYear;
            this.Course = course;
        }

        // Закрыть сессию. Возаращает true, если в результате закрытия сессии студент выпустился
        public bool CloseSession(Session sessionType)
        {
            if (sessionType == Session.Summer)
            {
                // Если последний курс, то выдать диплом и отчислить
                if (_course == 4)
                {
                    GetDiploma();
                    Delete();                    
                    return true;
                }
                // Иначе перевести на следующий курс
                else
                    _course++;
            }
            return false;
        }

        // Отчислить
        public void Delete()
        {
            _major = "None";
            _year = 0;
            _course = 0;
        }

        // Получить информацию о студенте
        public string[] GetInfo()
        {
            string[] info = { _fullName, _major, Convert.ToString(_year), Convert.ToString(_course) };
            return info;
        }

        // Выдать диплом
        private string GetDiploma()
        {
            return "This student waas given a diploma";
        }
    }
}
