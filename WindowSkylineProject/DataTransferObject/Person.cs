using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class Person
    {
        // Các field (biến thành viên)
        private int personId;         // Mã định danh (ID)
        private string userName;      // Tên đăng nhập
        private string password;      // Mật khẩu

        // Constructor đầy đủ (bao gồm personId)
        public Person(int personId, string userName, string password)
        {
            this.personId = personId;
            this.userName = userName;
            this.password = password;
        }

        // Constructor không có personId (dùng khi thêm mới, personId sẽ được DB tự tăng)
        public Person(string userName, string password)
        {
            this.userName = userName;
            this.password = password;
        }

        public int PersonID
        {
            get { return personId; }             // Lấy ID của người dùng
            set { personId = value; }            // Gán ID cho người dùng
        }

        public string UserName
        {
            get { return userName; }             // Lấy tên đăng nhập
            set { userName = value; }            // Gán tên đăng nhập
        }

        public string Password
        {
            get { return password; }             // Lấy mật khẩu
            set { password = value; }            // Gán mật khẩu
        }
    }
}
