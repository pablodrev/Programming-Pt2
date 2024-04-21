using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    public class EmptyStringException : Exception
    {
        public EmptyStringException(string message)
            : base(message) { }
    }
    public class WrongYearException : Exception
    {
        public WrongYearException(string message)
            : base(message) { }
    }
    public class WrongCourseException : Exception
    {
        public WrongCourseException(string message)
            : base(message) { }
    }
}
