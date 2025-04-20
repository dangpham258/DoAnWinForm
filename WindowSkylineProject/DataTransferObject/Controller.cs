using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class Controller : Person
    {
        // Constructor đầy đủ, bao gồm personId
        public Controller(int personId, string userName, string password)
            : base(personId, userName, password)
        {
        }

        // Constructor không có personId (dùng khi tạo mới đối tượng, personId sẽ được tự sinh)
        public Controller(string userName, string password)
            : base(userName, password)
        {
        }
    }
}
