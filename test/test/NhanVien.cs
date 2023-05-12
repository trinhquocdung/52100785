using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class NhanVien
    {
        private string __id;
        private string __name;
        private string __sex;
        private DateTime __dateOfBirth;
        private string __sdt;
        private string __email;

        public NhanVien()
        {
        }

        public NhanVien(string id, string name, string sex, DateTime dateOfBirth, string sdt, string email)
        {
            __id = id;
            __name = name;
            __sex = sex;
            __dateOfBirth = dateOfBirth;
            __sdt = sdt;
            __email = email;
        }

        public string Id { get => __id; set => __id = value; }
        public string Name { get => __name; set => __name = value; }
        public string Sex { get => __sex; set => __sex = value; }
        public DateTime dateOfBirth { get => __dateOfBirth; set => __dateOfBirth = value; }
        public string Sdt { get => __sdt; set => __sdt = value; }
        public string Email { get => __email; set => __email = value; }
    }
}
