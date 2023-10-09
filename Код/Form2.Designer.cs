namespace Код
{
    partial class Form2
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Register = new System.Windows.Forms.Button();
            this.Money = new System.Windows.Forms.Button();
            this.Contest = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Register
            // 
            this.Register.Location = new System.Drawing.Point(12, 12);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(134, 41);
            this.Register.TabIndex = 0;
            this.Register.Text = "Зареєструвати нового учасника клубу";
            this.Register.UseVisualStyleBackColor = true;
            this.Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // Money
            // 
            this.Money.Location = new System.Drawing.Point(165, 15);
            this.Money.Name = "Money";
            this.Money.Size = new System.Drawing.Size(115, 38);
            this.Money.TabIndex = 1;
            this.Money.Text = "Додати фінансові операції";
            this.Money.UseVisualStyleBackColor = true;
            this.Money.Click += new System.EventHandler(this.Money_Click);
            // 
            // Contest
            // 
            this.Contest.Location = new System.Drawing.Point(12, 59);
            this.Contest.Name = "Contest";
            this.Contest.Size = new System.Drawing.Size(108, 35);
            this.Contest.TabIndex = 2;
            this.Contest.Text = "Додати заходи";
            this.Contest.UseVisualStyleBackColor = true;
            this.Contest.Click += new System.EventHandler(this.Contest_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(165, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 39);
            this.button1.TabIndex = 3;
            this.button1.Text = "Переглянути запити";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(73, 116);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Завершення роботи";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ExitFromApplication);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 151);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Contest);
            this.Controls.Add(this.Money);
            this.Controls.Add(this.Register);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Register;
        private System.Windows.Forms.Button Money;
        private System.Windows.Forms.Button Contest;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}