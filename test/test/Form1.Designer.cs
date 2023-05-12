namespace test
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            Them = new Button();
            Xoa = new Button();
            Sua = new Button();
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            label5 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            label6 = new Label();
            DateOnly = new DateTimePicker();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 29);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã NV";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 80);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 1;
            label2.Text = "Họ tên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(364, 125);
            label3.Name = "label3";
            label3.Size = new Size(35, 20);
            label3.TabIndex = 2;
            label3.Text = "SDT";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(353, 76);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 3;
            label4.Text = "Email";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(96, 26);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(164, 27);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(413, 69);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(260, 27);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(96, 77);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(193, 27);
            textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(413, 118);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(193, 27);
            textBox4.TabIndex = 8;
            // 
            // Them
            // 
            Them.Location = new Point(772, 29);
            Them.Name = "Them";
            Them.Size = new Size(94, 29);
            Them.TabIndex = 9;
            Them.Text = "Thêm";
            Them.UseVisualStyleBackColor = true;
            Them.Click += button_Them_Click;
            // 
            // Xoa
            // 
            Xoa.Location = new Point(772, 76);
            Xoa.Name = "Xoa";
            Xoa.Size = new Size(94, 29);
            Xoa.TabIndex = 10;
            Xoa.Text = "Xóa";
            Xoa.UseVisualStyleBackColor = true;
            // 
            // Sua
            // 
            Sua.Location = new Point(772, 125);
            Sua.Name = "Sua";
            Sua.Size = new Size(94, 29);
            Sua.TabIndex = 11;
            Sua.Text = "Sửa";
            Sua.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(12, 196);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1012, 323);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 26);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1000, 291);
            dataGridView1.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(40, 121);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 13;
            label5.Text = "Giới tính";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(111, 121);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(62, 24);
            radioButton1.TabIndex = 16;
            radioButton1.TabStop = true;
            radioButton1.Text = "Nam";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(179, 121);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(50, 24);
            radioButton2.TabIndex = 17;
            radioButton2.TabStop = true;
            radioButton2.Text = "Nữ";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(325, 29);
            label6.Name = "label6";
            label6.Size = new Size(74, 20);
            label6.TabIndex = 18;
            label6.Text = "Ngày sinh";
            // 
            // DateOnly
            // 
            DateOnly.Location = new Point(413, 26);
            DateOnly.Name = "DateOnly";
            DateOnly.Size = new Size(273, 27);
            DateOnly.TabIndex = 19;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1036, 531);
            Controls.Add(DateOnly);
            Controls.Add(label6);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label5);
            Controls.Add(groupBox1);
            Controls.Add(Sua);
            Controls.Add(Xoa);
            Controls.Add(Them);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button Them;
        private Button Xoa;
        private Button Sua;
        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private Label label5;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Label label6;
        private DateTimePicker DateOnly;
    }
}