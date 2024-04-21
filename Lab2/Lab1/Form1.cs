using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Students;

namespace Lab1
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void switchAccess()
        {
            createButton.Enabled = !createButton.Enabled;
            sessionButton.Enabled = !sessionButton.Enabled;
            expelButton.Enabled = !expelButton.Enabled;
            changeMajorButton.Enabled = !changeMajorButton.Enabled;
            summerRadio.Enabled = !summerRadio.Enabled;
            winterRadio.Enabled = !winterRadio.Enabled;
            nameTextBox.Enabled = !nameTextBox.Enabled;
            majorTextBox.Enabled = !majorTextBox.Enabled;
            yearUpDown.Enabled = !yearUpDown.Enabled;
            courseUpDown.Enabled = !courseUpDown.Enabled;
            infoButton.Enabled = !infoButton.Enabled;
        }

        private void majorEditAccess()
        {
            sessionButton.Enabled = !sessionButton.Enabled;
            expelButton.Enabled = !expelButton.Enabled;
            infoButton.Enabled = !infoButton.Enabled;
            summerRadio.Enabled = !summerRadio.Enabled;
            winterRadio.Enabled = !winterRadio.Enabled;
            majorTextBox.Enabled = !majorTextBox.Enabled;
        }

        Student student;
        private void createButton_Click(object sender, EventArgs e)
        {
            try
            {
                student = new Student(nameTextBox.Text,
                                          majorTextBox.Text,
                                          Convert.ToInt32(yearUpDown.Value),
                                          Convert.ToInt32(courseUpDown.Value));
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
                yearUpDown.Value = 2023;
                MessageBox.Show("Неверно введен год!");

            }
            catch (WrongCourseException)
            {
                courseUpDown.Value = 1;
                MessageBox.Show("Неверное значение курса!");

            }
        }

        private void sessionButton_Click(object sender, EventArgs e)
        {
            if (summerRadio.Checked)
            {
                if (student.CloseSession(Session.Summer))
                {
                    MessageBox.Show("Студент закончил учебу и получил диплом. Добавьте нового студента.");
                    switchAccess();
                }
                else
                {
                    courseUpDown.Value = student.Course;
                }
            }
            else if (winterRadio.Checked)
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
            if (majorTextBox.Enabled)
                changeMajorButton.Text = "Подтвердить";
            else
                changeMajorButton.Text = "Сменить";
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
