using DataAccess;
using DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class FeedbackManage
    {
        FeedbackAccess _dal = new FeedbackAccess();
        public string SendFeedback(Feedback fb)
        {
            if (string.IsNullOrWhiteSpace(fb.FullName))
            {
                return "Vui lòng nhập họ tên";
            }
            if (fb.FullName.Length > 100)
            {
                return "Họ tên không được quá 100 ký tự";
            }
            if (string.IsNullOrWhiteSpace(fb.PhoneNumber))
            {
                return "Vui lòng nhập số điện thoại";
            }
            if (fb.PhoneNumber.Length > 20)
            {
                return "Số điện thoại không được quá 20 ký tự";
            }
            if (string.IsNullOrWhiteSpace(fb.Type))
            {
                return "Vui lòng chọn loại phản hồi";
            }
            if (fb.Detail?.Length > 255)
            {
                return "Nội dung phản hồi không được quá 255 ký tự";
            }
            if (string.IsNullOrWhiteSpace(fb.Detail) || fb.Detail == "Ngắn gọn, không quá 255 kí tự")
            {
                return "Vui lòng nhập nội dung phản hồi";
            }

            try
            {
                if (_dal.InsertFeedback(fb)) return "Gửi phản hồi thành công";
                return "Không thể lưu phản hồi\nVui lòng thử lại";
            }
            catch (Exception ex)
            {
                return "Lỗi hệ thống khi lưu phản hồi: " + ex.Message;
            }
        }

        public bool SeenFeedback(Feedback fb, bool notSeen)
        {
            try
            {
                if (fb != null)
                {
                    if (notSeen)
                        fb.Status = 0; // Đánh dấu phản hồi chưa xem
                    else
                        fb.Status = 1; // Đánh dấu phản hồi đã xem

                    return _dal.SetStatusFeedback(fb);
                }
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi đánh dấu phản hồi đã xem", ex);
            }
        }
    }
}
