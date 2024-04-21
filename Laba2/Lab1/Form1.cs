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
        // Метод, изменяющий видимость кнопок.
        // Нужен для переключения между режимами создания профиля студента и
        // выполнением функций (закрытие сессии, отчисление, информация о студенте)
        private void changeVisibility()
        {
            createButton.Enabled = !createButton.Enabled;
            sessionButton.Enabled = !sessionButton.Enabled;
            expelButton.Enabled = !expelButton.Enabled;
            changeMajorButton.Enabled = !changeMajorButton.Enabled;
            summerSessionRadio.Enabled = !summerSessionRadio.Enabled;
            winterSessionRadio.Enabled = !winterSessionRadio.Enabled;
            nameTextBox.Enabled = !nameTextBox.Enabled;
            majorTextBox.Enabled = !majorTextBox.Enabled;
            yearUpDown.Enabled = !yearUpDown.Enabled;
            courseUpDown.Enabled = !courseUpDown.Enabled;
            infoButton.Enabled = !infoButton.Enabled;
        }
        // Метод, изменющий видимость кнопок во время редактирования направления обучения
        // На время редактирования отключает все остальные кнопки
        private void majorChangeVisibility()
        {
            sessionButton.Enabled = !sessionButton.Enabled;
            expelButton.Enabled = !expelButton.Enabled;
            infoButton.Enabled = !infoButton.Enabled;
            summerSessionRadio.Enabled = !summerSessionRadio.Enabled;
            winterSessionRadio.Enabled = !winterSessionRadio.Enabled;
            majorTextBox.Enabled = !majorTextBox.Enabled;
        }
        // Инициализация класса студента глобально, чтобы он был доступен из любого метода
        Student student;

        // Кнопка создания профиля студента
        private void createButton_Click(object sender, EventArgs e)
        {
            // Обработка неправильно введенных данных через try ... catch
            // Исключения вызываются, если введена пустая строка, неправильный год (отрицательный)
            // или неправильный курс (меньше 1 или больше 4)
            try
            {
                student = new Student(nameTextBox.Text,
                                          majorTextBox.Text,
                                          Convert.ToInt32(yearUpDown.Value),
                                          Convert.ToInt32(courseUpDown.Value));
                changeVisibility();
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

        // Кнопка прохождения сессии
        private void sessionButton_Click(object sender, EventArgs e)
        {
            // Выбор сессии (зимняя или летняя)
            if (summerSessionRadio.Checked)
            {
                // Если студент закрыл летнюю сессиб на последнем курсе, то он получает диплом
                if (student.CloseSession(Session.Summer))
                {
                    MessageBox.Show("Студент закончил учебу и получил диплом. Добавьте нового студента.");
                    changeVisibility();
                }
                else
                {
                    courseUpDown.Value = student.Course;
                }
            }
            else if (winterSessionRadio.Checked)
            {
                student.CloseSession(Session.Winter);
            }
            MessageBox.Show("Студент закрыл сессию.");
        }

        // Кнопка отчисления студента
        private void expelButton_Click(object sender, EventArgs e)
        {
            student.Delete();
            MessageBox.Show("Студент отчислен. Добавьте нового студента");
            changeVisibility();
        }

        // Кнопка смены направления
        private void changeMajorButton_Click(object sender, EventArgs e)
        {
            // Еслм пользователь нажал "Сменить", то остальные кнопки отключаются
            // разрешается редактирование поля направления
            majorChangeVisibility();
            if (majorTextBox.Enabled)
                changeMajorButton.Text = "Подтвердить";
            else
                changeMajorButton.Text = "Сменить";
            // Проверка на ввод пустой строки
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

        // Кнопка с выводом информаци о студенте
        private void infoButton_Click(object sender, EventArgs e)
        {
            string[] info = student.GetInfo();
            MessageBox.Show(string.Join("\n", info));
        }
    }
}
