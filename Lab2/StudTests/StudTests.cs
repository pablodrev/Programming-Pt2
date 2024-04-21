using Microsoft.VisualStudio.TestTools.UnitTesting;
using Students;

namespace StudTests
{
    [TestClass]
    public class StudTests
    {
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

        [TestMethod]
        public void Student_EmptyName_ThrowsArgumentException()
        {
            // Arrange
            string emptyName = string.Empty;

            // Act and assert
            Assert.ThrowsException<EmptyStringException>(() => new Student(emptyName, "major", 2023, 1));
        }

        [TestMethod]
        public void Student_EmptyMajor_ThrowsArgumentException()
        {
            // Arrange
            string emptyMajor = string.Empty;

            // Act and assert
            Assert.ThrowsException<EmptyStringException>(() => new Student("name", emptyMajor, 2023, 1));
        }

        [TestMethod]
        public void Student_NegativeYear_ThrowsArgumentException()
        {
            // Arrange
            int negativeYear = -1;

            // Act and assert
            Assert.ThrowsException<WrongYearException>(() => new Student("name", "major", negativeYear, 1));
        }

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

