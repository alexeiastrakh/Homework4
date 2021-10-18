namespace WindowsForms_task1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            this.HintForUser = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Input = new System.Windows.Forms.TextBox();
            this.OutPut = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // HintForUser
            // 
            this.HintForUser.AutoSize = true;
            this.HintForUser.Location = new System.Drawing.Point(115, 219);
            this.HintForUser.Name = "HintForUser";
            this.HintForUser.Size = new System.Drawing.Size(0, 13);
            this.HintForUser.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(102, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Action!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(102, 145);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(100, 20);
            this.Input.TabIndex = 2;
            this.Input.TextChanged += new System.EventHandler(this.Input_TextChanged);
            // 
            // OutPut
            // 
            this.OutPut.AutoSize = true;
            this.OutPut.Location = new System.Drawing.Point(29, 26);
            this.OutPut.Name = "OutPut";
            this.OutPut.Size = new System.Drawing.Size(0, 13);
            this.OutPut.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.OutPut);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.HintForUser);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

            private System.Windows.Forms.Label HintForUser;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Input;
        private System.Windows.Forms.Label OutPut;

    }
}

