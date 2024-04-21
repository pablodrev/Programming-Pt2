using Students;
using System;
using System.Windows;

namespace Lab3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            sessionButton.IsEnabled = false;
            expelButton.IsEnabled = false;
            changeMajorButton.IsEnabled = false;
            summerRadio.IsEnabled = false;
            winterRadio.IsEnabled = false;
            infoButton.IsEnabled = false;
        }
        private void switchAccess()
        {
            createButton.IsEnabled = !createButton.IsEnabled;
            sessionButton.IsEnabled = !sessionButton.IsEnabled;
            expelButton.IsEnabled = !expelButton.IsEnabled;
            changeMajorButton.IsEnabled = !changeMajorButton.IsEnabled;
            summerRadio.IsEnabled = !summerRadio.IsEnabled;
            winterRadio.IsEnabled = !winterRadio.IsEnabled;
            nameTextBox.IsEnabled = !nameTextBox.IsEnabled;
            majorTextBox.IsEnabled = !majorTextBox.IsEnabled;
            yearTextBox.IsEnabled = !yearTextBox.IsEnabled;
            courseTextBox.IsEnabled = !courseTextBox.IsEnabled;
            infoButton.IsEnabled = !infoButton.IsEnabled;
        }

        private void majorEditAccess()
        {
            sessionButton.IsEnabled = !sessionButton.IsEnabled;
            expelButton.IsEnabled = !expelButton.IsEnabled;
            infoButton.IsEnabled = !infoButton.IsEnabled;
            summerRadio.IsEnabled = !summerRadio.IsEnabled;
            winterRadio.IsEnabled = !winterRadio.IsEnabled;
            majorTextBox.IsEnabled = !majorTextBox.IsEnabled;
        }

        Student student;
        private void createButton_Click(object sender, EventArgs e)
        {
            try
            {
                student = new Student(nameTextBox.Text,
                                          majorTextBox.Text,
                                          Convert.ToInt32(yearTextBox.Text),
                                          Convert.ToInt32(courseTextBox.Text));
                switchAccess();
            }
            catch (EmptyStringException)
            {
                nameTextBox.Text = "Введите Ф.И.О.";
                majorTextBox.Text = "Введите направление";
                MessageBox.Show("Обнаружена пустая строка! Ввеите верные данные.");

            }
            catch (WrongYearException)
            {
                yearTextBox.Text = "2023";
                MessageBox.Show("Неверно введен год!");

            }
            catch (WrongCourseException)
            {
                courseTextBox.Text = "1";
                MessageBox.Show("Неверное значение курса!");

            }
        }

        private void sessionButton_Click(object sender, EventArgs e)
        {
            if (summerRadio.IsChecked == true)
            {
                if (student.CloseSession(Session.Summer))
                {
                    MessageBox.Show("Студент закончил учебу и получил диплом. Добавьте нового студента.");
                    switchAccess();
                    return;
                }
                else
                {
                    courseTextBox.Text = student.Course.ToString();
                }
            }
            else if (winterRadio.IsChecked == true)
            {
                student.CloseSession(Session.Winter);
            }
            MessageBox.Show("Студент закрыл сессию.");
        }

        private void expelButton_Click(object sender, EventArgs e)
        {
            student.Expel();
            MessageBox.Show("Студент отчислен. Добавьте нового студента");
            switchAccess();
        }

        private void changeMajorButton_Click(object sender, EventArgs e)
        {
            majorEditAccess();
            if (majorTextBox.IsEnabled)
                changeMajorButton.Content = "Подтвердить";
            else
                changeMajorButton.Content = "Сменить";
            try
            {
                student.Major = majorTextBox.Text;
            }
            catch (EmptyStringException)
            {
                majorTextBox.Text = "Введите направление";
                MessageBox.Show("Ввеите непустое значение!");
            }

        }


        private void infoButton_Click(object sender, EventArgs e)
        {
            string[] info = student.GetInfo();
            MessageBox.Show(string.Join("\n", info));
        }
    }
}

