using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class CheckBookingInformationForm
    {
        public static string Validate(string hoten, string sdt, string cccd)
        {
            if (string.IsNullOrWhiteSpace(hoten))
                return "Vui lòng nhập họ tên!";

            if (string.IsNullOrWhiteSpace(sdt))
                return "Vui lòng nhập số điện thoại!";

            if (string.IsNullOrWhiteSpace(cccd))
                return "Vui lòng nhập số CCCD!";

            if (sdt.Trim().Length != 10)
                return "Số điện thoại phải hợp lệ!";

            if (cccd.Trim().Length != 12)
                return "CCCD phải hợp lệ!";

            return null;
        }
    }
}
