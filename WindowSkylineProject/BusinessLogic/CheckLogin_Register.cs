using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DataTransferObject;
using DataAccess;

namespace BusinessLogic
{
    public class CheckLogin_Register
    {
        public string CheckLogin(Passenger passenger)
        {
            try
            {
                if (string.IsNullOrEmpty(passenger.UserName))
                {
                    return "Tên người dùng không được để trống";
                }
                if (string.IsNullOrEmpty(passenger.Password))
                {
                    return "Mật khẩu không được để trống";
                }
                CheckLogin_RegisterAccess checkPassengerLoginAccess = new CheckLogin_RegisterAccess();
                if (!checkPassengerLoginAccess.IsExist(passenger))
                {
                    return "Tên người dùng hoặc mật khẩu không đúng";
                }
                return "Đăng nhập thành công";
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi kiểm tra đăng nhập: " + ex.Message, ex);
            }
        }

        public string CheckLogin(Controller controller)
        {
            try
            {
                if (string.IsNullOrEmpty(controller.UserName))
                {
                    return "Tên người dùng không được để trống";
                }
                if (string.IsNullOrEmpty(controller.Password))
                {
                    return "Mật khẩu không được để trống";
                }
                CheckLogin_RegisterAccess checkPassengerLoginAccess = new CheckLogin_RegisterAccess();
                if (!checkPassengerLoginAccess.IsExist(controller))
                {
                    return "Tên người dùng hoặc mật khẩu không đúng";
                }
                return "Đăng nhập thành công";
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi kiểm tra đăng nhập: " + ex.Message, ex);
            }
        }

        public string CheckLogin(CrewMember crewMember)
        {
            try
            {
                if (string.IsNullOrEmpty(crewMember.UserName))
                {
                    return "Tên người dùng không được để trống";
                }
                if (string.IsNullOrEmpty(crewMember.Password))
                {
                    return "Mật khẩu không được để trống";
                }
                CheckLogin_RegisterAccess checkPassengerLoginAccess = new CheckLogin_RegisterAccess();
                if (!checkPassengerLoginAccess.IsExist(crewMember))
                {
                    return "Tên người dùng hoặc mật khẩu không đúng";
                }
                return "Đăng nhập thành công";
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi kiểm tra đăng nhập: " + ex.Message, ex);
            }
        }

        public string Register(Passenger passenger, string confirmPassword)
        {
            try
            {
                if (string.IsNullOrEmpty(passenger.FullName))
                {
                    return "Họ tên không được để trống";
                }
                if (string.IsNullOrEmpty(passenger.UserName))
                {
                    return "Tên người dùng không được để trống";
                }
                if (passenger.UserName.Trim().Contains(" "))
                {
                    return "Tên user không được chứa khoảng trắng";
                }
                if (string.IsNullOrEmpty(passenger.Password))
                {
                    return "Mật khẩu không được để trống";
                }
                if (passenger.Password.Length < 6)
                {
                    return "Mật khẩu phải có ít nhất 6 ký tự";
                }
                if (string.IsNullOrEmpty(confirmPassword))
                {
                    return "Vui lòng nhập xác minh mật khẩu";
                }
                if (!passenger.Password.Equals(confirmPassword))
                {
                    return "Mật khẩu không khớp";
                }
                CheckLogin_RegisterAccess checkPassengerLoginAccess = new CheckLogin_RegisterAccess();
                if (checkPassengerLoginAccess.IsExist(passenger))
                {
                    return "Người dùng đã tồn tại";
                }
                CheckLogin_RegisterAccess checkPassengerRegisterAccess = new CheckLogin_RegisterAccess();
                checkPassengerRegisterAccess.Register(passenger);
                return "Đăng ký thành công";
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi đăng ký: " + ex.Message, ex);
            }
        }
    }
}
