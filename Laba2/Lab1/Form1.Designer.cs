﻿namespace Lab1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.majorTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.courseUpDown = new System.Windows.Forms.NumericUpDown();
            this.yearUpDown = new System.Windows.Forms.NumericUpDown();
            this.createButton = new System.Windows.Forms.Button();
            this.sessionButton = new System.Windows.Forms.Button();
            this.expelButton = new System.Windows.Forms.Button();
            this.changeMajorButton = new System.Windows.Forms.Button();
            this.summerSessionRadio = new System.Windows.Forms.RadioButton();
            this.winterSessionRadio = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.infoButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.courseUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameTextBox.Location = new System.Drawing.Point(35, 47);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(142, 24);
            this.nameTextBox.TabIndex = 0;
            this.nameTextBox.Text = "Введите Ф.И.О.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(32, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ф.И.О. студента:";
            // 
            // majorTextBox
            // 
            this.majorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.majorTextBox.Location = new System.Drawing.Point(35, 115);
            this.majorTextBox.Name = "majorTextBox";
            this.majorTextBox.Size = new System.Drawing.Size(170, 24);
            this.majorTextBox.TabIndex = 2;
            this.majorTextBox.Text = "Введите направление";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(32, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Направление обучения:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(32, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Год зачисления:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(32, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Курс:";
            // 
            // courseUpDown
            // 
            this.courseUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.courseUpDown.Location = new System.Drawing.Point(35, 282);
            this.courseUpDown.Name = "courseUpDown";
            this.courseUpDown.Size = new System.Drawing.Size(48, 24);
            this.courseUpDown.TabIndex = 6;
            this.courseUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // yearUpDown
            // 
            this.yearUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yearUpDown.Location = new System.Drawing.Point(36, 213);
            this.yearUpDown.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.yearUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.yearUpDown.Name = "yearUpDown";
            this.yearUpDown.Size = new System.Drawing.Size(62, 24);
            this.yearUpDown.TabIndex = 7;
            this.yearUpDown.Value = new decimal(new int[] {
            2023,
            0,
            0,
            0});
            // 
            // createButton
            // 
            this.createButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createButton.Location = new System.Drawing.Point(35, 338);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(142, 44);
            this.createButton.TabIndex = 10;
            this.createButton.Text = "Создать";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // sessionButton
            // 
            this.sessionButton.Enabled = false;
            this.sessionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sessionButton.Location = new System.Drawing.Point(331, 172);
            this.sessionButton.Name = "sessionButton";
            this.sessionButton.Size = new System.Drawing.Size(125, 38);
            this.sessionButton.TabIndex = 11;
            this.sessionButton.Text = "Закрыть сессию";
            this.sessionButton.UseVisualStyleBackColor = true;
            this.sessionButton.Click += new System.EventHandler(this.sessionButton_Click);
            // 
            // expelButton
            // 
            this.expelButton.Enabled = false;
            this.expelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.expelButton.Location = new System.Drawing.Point(331, 231);
            this.expelButton.Name = "expelButton";
            this.expelButton.Size = new System.Drawing.Size(125, 38);
            this.expelButton.TabIndex = 12;
            this.expelButton.Text = "Отчислить";
            this.expelButton.UseVisualStyleBackColor = true;
            this.expelButton.Click += new System.EventHandler(this.expelButton_Click);
            // 
            // changeMajorButton
            // 
            this.changeMajorButton.Enabled = false;
            this.changeMajorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeMajorButton.Location = new System.Drawing.Point(35, 145);
            this.changeMajorButton.Name = "changeMajorButton";
            this.changeMajorButton.Size = new System.Drawing.Size(77, 24);
            this.changeMajorButton.TabIndex = 13;
            this.changeMajorButton.Text = "Сменить";
            this.changeMajorButton.UseVisualStyleBackColor = true;
            this.changeMajorButton.Click += new System.EventHandler(this.changeMajorButton_Click);
            // 
            // summerRadio
            // 
            this.summerSessionRadio.AutoSize = true;
            this.summerSessionRadio.Enabled = false;
            this.summerSessionRadio.Location = new System.Drawing.Point(331, 87);
            this.summerSessionRadio.Name = "summerRadio";
            this.summerSessionRadio.Size = new System.Drawing.Size(62, 17);
            this.summerSessionRadio.TabIndex = 14;
            this.summerSessionRadio.Text = "Летняя";
            this.summerSessionRadio.UseVisualStyleBackColor = true;
            // 
            // winterRadio
            // 
            this.winterSessionRadio.AutoSize = true;
            this.winterSessionRadio.Checked = true;
            this.winterSessionRadio.Enabled = false;
            this.winterSessionRadio.Location = new System.Drawing.Point(331, 112);
            this.winterSessionRadio.Name = "winterRadio";
            this.winterSessionRadio.Size = new System.Drawing.Size(64, 17);
            this.winterSessionRadio.TabIndex = 15;
            this.winterSessionRadio.TabStop = true;
            this.winterSessionRadio.Text = "Зимняя";
            this.winterSessionRadio.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(315, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(196, 81);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Тип сессии";
            // 
            // infoButton
            // 
            this.infoButton.Enabled = false;
            this.infoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoButton.Location = new System.Drawing.Point(331, 337);
            this.infoButton.Name = "infoButton";
            this.infoButton.Size = new System.Drawing.Size(125, 45);
            this.infoButton.TabIndex = 17;
            this.infoButton.Text = "Информация о студенте";
            this.infoButton.UseVisualStyleBackColor = true;
            this.infoButton.Click += new System.EventHandler(this.infoButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 411);
            this.Controls.Add(this.infoButton);
            this.Controls.Add(this.winterSessionRadio);
            this.Controls.Add(this.summerSessionRadio);
            this.Controls.Add(this.changeMajorButton);
            this.Controls.Add(this.expelButton);
            this.Controls.Add(this.sessionButton);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.yearUpDown);
            this.Controls.Add(this.courseUpDown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.majorTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Студент";
            ((System.ComponentModel.ISupportInitialize)(this.courseUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox majorTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown courseUpDown;
        private System.Windows.Forms.NumericUpDown yearUpDown;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button sessionButton;
        private System.Windows.Forms.Button expelButton;
        private System.Windows.Forms.Button changeMajorButton;
        private System.Windows.Forms.RadioButton summerSessionRadio;
        private System.Windows.Forms.RadioButton winterSessionRadio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button infoButton;
    }
}

