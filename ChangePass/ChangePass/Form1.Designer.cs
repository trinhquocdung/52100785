namespace ChangePass
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            tbnConfirmPassword = new Label();
            tbnNewPassword = new Label();
            tbnCurrentPassword = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(394, 292);
            button1.Name = "button1";
            button1.Size = new Size(143, 54);
            button1.TabIndex = 13;
            button1.Text = "Change";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(382, 222);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(182, 27);
            textBox3.TabIndex = 12;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(382, 162);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(182, 27);
            textBox2.TabIndex = 11;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(382, 104);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(182, 27);
            textBox1.TabIndex = 10;
            // 
            // tbnConfirmPassword
            // 
            tbnConfirmPassword.AutoSize = true;
            tbnConfirmPassword.Location = new Point(236, 225);
            tbnConfirmPassword.Name = "tbnConfirmPassword";
            tbnConfirmPassword.Size = new Size(123, 20);
            tbnConfirmPassword.TabIndex = 9;
            tbnConfirmPassword.Text = "Confirm NewPass";
            // 
            // tbnNewPassword
            // 
            tbnNewPassword.AutoSize = true;
            tbnNewPassword.Location = new Point(289, 162);
            tbnNewPassword.Name = "tbnNewPassword";
            tbnNewPassword.Size = new Size(70, 20);
            tbnNewPassword.TabIndex = 8;
            tbnNewPassword.Text = "New Pass";
            // 
            // tbnCurrentPassword
            // 
            tbnCurrentPassword.AutoSize = true;
            tbnCurrentPassword.Location = new Point(271, 104);
            tbnCurrentPassword.Name = "tbnCurrentPassword";
            tbnCurrentPassword.Size = new Size(88, 20);
            tbnCurrentPassword.TabIndex = 7;
            tbnCurrentPassword.Text = "Current Pass";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(tbnConfirmPassword);
            Controls.Add(tbnNewPassword);
            Controls.Add(tbnCurrentPassword);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label tbnConfirmPassword;
        private Label tbnNewPassword;
        private Label tbnCurrentPassword;
    }
}