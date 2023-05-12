using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace test
{
    class Modify
    {
        SqlDataAdapter dataAdapter; //truy xuat du lieu vao bang
        SqlCommand sqlCommand; //truy van va cap nhat CSDL
        public Modify()
        {
        }
        public DataTable getALLNhanVien()
        {
            DataTable dataTable = new DataTable();
            string query = "select * from Nhanvien";
            using SqlConnection sqlConnection = Connection.getConnection();
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(query, sqlConnection);
                dataAdapter.Fill(dataTable);
                sqlConnection.Close();
            }
            return dataTable;
        }
        public bool insert(NhanVien nhanvien)
        {
            SqlConnection sqlConnection = Connection.getConnection();
            string query = "insert into Nhanvien values (@maNV, @maTK, @Hoten, @GioiTinh, @NgaySinh, @SDT, @Email)";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@maNV", SqlDbType.NVarChar).Value = nhanvien.Id;
                sqlCommand.Parameters.Add("@Hoten", SqlDbType.NVarChar).Value = nhanvien.Name;
                sqlCommand.Parameters.Add("@GioiTinh", SqlDbType.NVarChar).Value = nhanvien.Sex;
                sqlCommand.Parameters.Add("@NgaySinh", SqlDbType.NVarChar).Value = nhanvien.dateOfBirth.ToShortDateString();
                sqlCommand.Parameters.Add("@SDT", SqlDbType.NVarChar).Value = nhanvien.Sdt;
                sqlCommand.Parameters.Add("@Email", SqlDbType.NVarChar).Value = nhanvien.Email;
                sqlCommand.ExecuteNonQuery(); //thuc thi lenh truy van
            }
            catch
            {
                return false;
            }
            finally
            {
                sqlConnection.Close ();
            }
            return true;
        }
    }
}
