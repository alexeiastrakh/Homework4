namespace WindowsForms_task3
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
            this.OUTPUT1 = new System.Windows.Forms.Label();
            this.OUTPUT2 = new System.Windows.Forms.Label();
            this.Input1 = new System.Windows.Forms.TextBox();
            this.Input2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(45, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "IsoscelesTriangle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(427, 50);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "RectangularTriangle";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // OUTPUT1
            // 
            this.OUTPUT1.AutoSize = true;
            this.OUTPUT1.Location = new System.Drawing.Point(64, 98);
            this.OUTPUT1.Name = "OUTPUT1";
            this.OUTPUT1.Size = new System.Drawing.Size(0, 13);
            this.OUTPUT1.TabIndex = 2;
            // 
            // OUTPUT2
            // 
            this.OUTPUT2.AutoSize = true;
            this.OUTPUT2.Location = new System.Drawing.Point(487, 98);
            this.OUTPUT2.Name = "OUTPUT2";
            this.OUTPUT2.Size = new System.Drawing.Size(0, 13);
            this.OUTPUT2.TabIndex = 3;
            // 
            // Input1
            // 
            this.Input1.Location = new System.Drawing.Point(45, 135);
            this.Input1.Name = "Input1";
            this.Input1.Size = new System.Drawing.Size(100, 20);
            this.Input1.TabIndex = 4;
            this.Input1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Input2
            // 
            this.Input2.Location = new System.Drawing.Point(456, 135);
            this.Input2.Name = "Input2";
            this.Input2.Size = new System.Drawing.Size(100, 20);
            this.Input2.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 261);
            this.Controls.Add(this.Input2);
            this.Controls.Add(this.Input1);
            this.Controls.Add(this.OUTPUT2);
            this.Controls.Add(this.OUTPUT1);
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
        private System.Windows.Forms.Label OUTPUT1;
        private System.Windows.Forms.Label OUTPUT2;
        private System.Windows.Forms.TextBox Input1;
        private System.Windows.Forms.TextBox Input2;
    }
}

