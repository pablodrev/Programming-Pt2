using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    // Вспомогательные классы исключений.

    // Исключение пустой строки
    public class EmptyStringException : Exception
    {
        public EmptyStringException(string message)
            : base(message) { }
    }
    // Исключение неправильного года
    public class WrongYearException : Exception
    {
        public WrongYearException(string message)
            : base(message) { }
    }
    // Исключение неправильного курса
    public class WrongCourseException : Exception
    {
        public WrongCourseException(string message)
            : base(message) { }
    }
}
