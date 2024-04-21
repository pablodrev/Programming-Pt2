using Microsoft.VisualStudio.TestTools.UnitTesting;
using Students;

namespace StudTests
{
    [TestClass]
    public class StudTests
    {
        // Проверка на то, увеличивается ли курс при прохождении летней сессии
        [TestMethod]
        public void CloseSession_IfSummer_NextCourse()
        {
            // Arrange
            int course = 1;
            int expectedCourse = 2;
            Student student = new Student("name", "major", 2023, course);

            // Act
            student.CloseSession(Session.Summer);

            // Assert
            int actualCourse = student.Course;
            Assert.AreEqual(expectedCourse, actualCourse);

        }

        // Проверка на то, отчисляется ли студент, если он выпустился с последнего курса
        [TestMethod]
        public void CloseSession_IfLastCourse_ExpelStudent()
        {
            // Arrange
            int course = 4;
            int expectedCourse = 0;
            Student student = new Student("name", "major", 2023, course);

            // Act
            student.CloseSession(Session.Summer);

            // Assert
            int actualCourse = student.Course;
            Assert.AreEqual(expectedCourse, actualCourse);
        }

        // Проверка на то, возвращает ли CloseSession значение true, когда студент выскается
        [TestMethod]
        public void CloseSession_IfLastCourse_ReturnTrue()
        {
            // Arrange
            Student student = new Student("name", "major", 2023, 4);


            // Act
            bool actual = student.CloseSession(Session.Summer);

            // Act and assert
            Assert.IsTrue(actual);
        }

        // Проверка на то, вызывается ли исключение пустой строки, если ввести пустое имя
        [TestMethod]
        public void Student_EmptyName_ThrowsArgumentException()
        {
            // Arrange
            string emptyName = string.Empty;

            // Act and assert
            Assert.ThrowsException<EmptyStringException>(() => new Student(emptyName, "major", 2023, 1));
        }

        // Проверка на то, вызывается ли исключение пустой строки, если ввести пустое направление
        [TestMethod]
        public void Student_EmptyMajor_ThrowsArgumentException()
        {
            // Arrange
            string emptyMajor = string.Empty;

            // Act and assert
            Assert.ThrowsException<EmptyStringException>(() => new Student("name", emptyMajor, 2023, 1));
        }

        // Проверка на то, вызывается ли исключение неправильного года, если введен отрицательный год
        [TestMethod]
        public void Student_NegativeYear_ThrowsArgumentException()
        {
            // Arrange
            int negativeYear = -1;

            // Act and assert
            Assert.ThrowsException<WrongYearException>(() => new Student("name", "major", negativeYear, 1));
        }

        // Проверка на то, вызывается ли исключение неправильного курса, если пользователь введет 8 курс
        [TestMethod]
        public void Student_CourseOutOfRange_ThrowsArgumentException()
        {
            // Arrange
            int wrongCourse = 8;

            // Act and assert
            Assert.ThrowsException<WrongCourseException>(() => new Student("name", "major", 2023, wrongCourse));
        }
    }
}

