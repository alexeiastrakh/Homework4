﻿namespace WindowsForms_task2
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.Input1 = new System.Windows.Forms.TextBox();
            this.Input2 = new System.Windows.Forms.TextBox();
            this.Input3 = new System.Windows.Forms.TextBox();
            this.Input4 = new System.Windows.Forms.TextBox();
            this.Input5 = new System.Windows.Forms.TextBox();
            this.OUTPUT1 = new System.Windows.Forms.Label();
            this.OUTPUT2 = new System.Windows.Forms.Label();
            this.OUTPUT3 = new System.Windows.Forms.Label();
            this.OUTPUT4 = new System.Windows.Forms.Label();
            this.OUTPUT5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Triangle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(21, 115);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Rectangle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(465, 24);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Circle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(465, 115);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Square";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 217);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "Rhombus";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Input1
            // 
            this.Input1.Location = new System.Drawing.Point(12, 75);
            this.Input1.Name = "Input1";
            this.Input1.Size = new System.Drawing.Size(100, 20);
            this.Input1.TabIndex = 5;
            this.Input1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Input2
            // 
            this.Input2.Location = new System.Drawing.Point(456, 75);
            this.Input2.Name = "Input2";
            this.Input2.Size = new System.Drawing.Size(100, 20);
            this.Input2.TabIndex = 6;
            // 
            // Input3
            // 
            this.Input3.Location = new System.Drawing.Point(12, 164);
            this.Input3.Name = "Input3";
            this.Input3.Size = new System.Drawing.Size(100, 20);
            this.Input3.TabIndex = 7;
            this.Input3.TextChanged += new System.EventHandler(this.Input3_TextChanged);
            // 
            // Input4
            // 
            this.Input4.Location = new System.Drawing.Point(456, 164);
            this.Input4.Name = "Input4";
            this.Input4.Size = new System.Drawing.Size(100, 20);
            this.Input4.TabIndex = 8;
            this.Input4.TextChanged += new System.EventHandler(this.Input4_TextChanged);
            // 
            // Input5
            // 
            this.Input5.Location = new System.Drawing.Point(12, 297);
            this.Input5.Name = "Input5";
            this.Input5.Size = new System.Drawing.Size(100, 20);
            this.Input5.TabIndex = 9;
            this.Input5.TextChanged += new System.EventHandler(this.Input5_TextChanged);
            // 
            // OUTPUT1
            // 
            this.OUTPUT1.AutoSize = true;
            this.OUTPUT1.Location = new System.Drawing.Point(45, 56);
            this.OUTPUT1.Name = "OUTPUT1";
            this.OUTPUT1.Size = new System.Drawing.Size(0, 13);
            this.OUTPUT1.TabIndex = 10;
            // 
            // OUTPUT2
            // 
            this.OUTPUT2.AutoSize = true;
            this.OUTPUT2.Location = new System.Drawing.Point(485, 56);
            this.OUTPUT2.Name = "OUTPUT2";
            this.OUTPUT2.Size = new System.Drawing.Size(0, 13);
            this.OUTPUT2.TabIndex = 11;
            // 
            // OUTPUT3
            // 
            this.OUTPUT3.AutoSize = true;
            this.OUTPUT3.Location = new System.Drawing.Point(38, 145);
            this.OUTPUT3.Name = "OUTPUT3";
            this.OUTPUT3.Size = new System.Drawing.Size(0, 13);
            this.OUTPUT3.TabIndex = 12;
            // 
            // OUTPUT4
            // 
            this.OUTPUT4.AutoSize = true;
            this.OUTPUT4.Location = new System.Drawing.Point(485, 145);
            this.OUTPUT4.Name = "OUTPUT4";
            this.OUTPUT4.Size = new System.Drawing.Size(0, 13);
            this.OUTPUT4.TabIndex = 13;
            // 
            // OUTPUT5
            // 
            this.OUTPUT5.AutoSize = true;
            this.OUTPUT5.Location = new System.Drawing.Point(38, 265);
            this.OUTPUT5.Name = "OUTPUT5";
            this.OUTPUT5.Size = new System.Drawing.Size(0, 13);
            this.OUTPUT5.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 348);
            this.Controls.Add(this.OUTPUT5);
            this.Controls.Add(this.OUTPUT4);
            this.Controls.Add(this.OUTPUT3);
            this.Controls.Add(this.OUTPUT2);
            this.Controls.Add(this.OUTPUT1);
            this.Controls.Add(this.Input5);
            this.Controls.Add(this.Input4);
            this.Controls.Add(this.Input3);
            this.Controls.Add(this.Input2);
            this.Controls.Add(this.Input1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox Input1;
        private System.Windows.Forms.TextBox Input2;
        private System.Windows.Forms.TextBox Input3;
        private System.Windows.Forms.TextBox Input4;
        private System.Windows.Forms.TextBox Input5;
        private System.Windows.Forms.Label OUTPUT1;
        private System.Windows.Forms.Label OUTPUT2;
        private System.Windows.Forms.Label OUTPUT3;
        private System.Windows.Forms.Label OUTPUT4;
        private System.Windows.Forms.Label OUTPUT5;

    }
}

