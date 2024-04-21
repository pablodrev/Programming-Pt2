using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            Student student = new Student(nameTextBox.Text, 
                                          majorTextBox.Text, 
                                          Convert.ToInt32(yearUpDown.Value), 
                                          Convert.ToInt32(courseUpDown.Value));
            sessionButton.Enabled = true;
            expelButton.Enabled = true;
            changeMajorButton.Enabled = true;
            nameTextBox.Enabled = false;
            majorTextBox.Enabled = false;
            yearUpDown.Enabled = false;
            courseUpDown.Enabled = false;
        }

        private void sessionButton_Click(object sender, EventArgs e)
        {

        }

        private void expelButton_Click(object sender, EventArgs e)
        {

        }

        private void changeMajorButton_Click(object sender, EventArgs e)
        {

        }
    }
}
