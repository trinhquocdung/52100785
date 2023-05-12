using System;
using System.Windows.Forms;

namespace ChangePass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string currentPassword = tbnCurrentPassword.Text;
            string newPassword = tbnNewPassword.Text;
            string confirmPassword = tbnConfirmPassword.Text;

            // Kiểm tra các điều kiện đổi mật khẩu
            if (string.IsNullOrEmpty(currentPassword) || string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Mật khẩu mới và xác nhận mật khẩu không khớp!");
                return;
            }

            // Thực hiện việc đổi mật khẩu ở đây
            // ...

            MessageBox.Show("Đổi mật khẩu thành công!");
            this.Close();
        }
    }
}
