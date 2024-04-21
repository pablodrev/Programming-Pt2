namespace Lab1
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.createButton = new System.Windows.Forms.Button();
            this.sessionButton = new System.Windows.Forms.Button();
            this.expelButton = new System.Windows.Forms.Button();
            this.changeMajorButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.courseUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameTextBox.Location = new System.Drawing.Point(35, 94);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(142, 24);
            this.nameTextBox.TabIndex = 0;
            this.nameTextBox.Text = "Введите Ф.И.О.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(32, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ф.И.О. студента:";
            // 
            // majorTextBox
            // 
            this.majorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.majorTextBox.Location = new System.Drawing.Point(35, 162);
            this.majorTextBox.Name = "majorTextBox";
            this.majorTextBox.Size = new System.Drawing.Size(170, 24);
            this.majorTextBox.TabIndex = 2;
            this.majorTextBox.Text = "Введите направление";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(32, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Направление обучения:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(32, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Год зачисления:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(32, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Курс:";
            // 
            // courseUpDown
            // 
            this.courseUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.courseUpDown.Location = new System.Drawing.Point(35, 297);
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
            this.yearUpDown.Location = new System.Drawing.Point(36, 228);
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(86, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Данные";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(339, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Действия";
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
            this.sessionButton.Location = new System.Drawing.Point(331, 80);
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
            this.expelButton.Location = new System.Drawing.Point(331, 137);
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
            this.changeMajorButton.Location = new System.Drawing.Point(211, 162);
            this.changeMajorButton.Name = "changeMajorButton";
            this.changeMajorButton.Size = new System.Drawing.Size(77, 24);
            this.changeMajorButton.TabIndex = 13;
            this.changeMajorButton.Text = "Сменить";
            this.changeMajorButton.UseVisualStyleBackColor = true;
            this.changeMajorButton.Click += new System.EventHandler(this.changeMajorButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 411);
            this.Controls.Add(this.changeMajorButton);
            this.Controls.Add(this.expelButton);
            this.Controls.Add(this.sessionButton);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.yearUpDown);
            this.Controls.Add(this.courseUpDown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.majorTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameTextBox);
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button sessionButton;
        private System.Windows.Forms.Button expelButton;
        private System.Windows.Forms.Button changeMajorButton;
    }
}

