namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Modify modify;
        NhanVien nhanvien;
        private void Form1_Load(object sender, EventArgs e)
        {
            modify = new Modify();
            try
            {
                dataGridView1.DataSource = modify.getALLNhanVien();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void button_Them_Click(object sender, EventArgs e)
        {
            string id = this.label1.Text;
            string name = this.label2.Text;
            string sex = (radioButton1.Checked ? radioButton1.Text : radioButton2.Text);
            DateTime dateOfBirth = this.DateOnly.Value;
            string SDT = this.label3.Text;
            string Email = this.label4.Text;
            nhanvien = new NhanVien(id, name, sex, dateOfBirth, SDT, Email);
            if (modify.insert(nhanvien))
            {
                dataGridView1.DataSource = modify.getALLNhanVien();
            }
            else
            {
                MessageBox.Show("Lỗi: " + "không thêm vào được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}