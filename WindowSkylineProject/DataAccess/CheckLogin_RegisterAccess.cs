using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DataTransferObject;

namespace DataAccess
{
    public class CheckLogin_RegisterAccess : Database
    {
        SqlConnection conn;
        public CheckLogin_RegisterAccess()
        {
            conn = base.sqlConn;
        }
        public bool IsExist(ILogin login)
        {
            try
            {
                string query = $"SELECT COUNT(*) FROM {login.TableInDB} " +
                    "WHERE UserName = @UserName AND Password = @Password";
                List<SqlParameter> parameters = new List<SqlParameter>
                {
                    new SqlParameter("@UserName", login.UserName),
                    new SqlParameter("@Password", login.Password)
                };

                object result = ExecuteScalar(query, parameters);
                int count = Convert.ToInt32(result);
                return count > 0;
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Lỗi kiểm tra tài khoản", ex);
            }
        }

        public bool Register(Passenger passenger)
        {
            try
            {
                string query = "INSERT INTO Table_UserDatabase (FullName, UserName, Password) VALUES (@FullName, @UserName, @Password)";
                List<SqlParameter> parameters = new List<SqlParameter>
                {
                    new SqlParameter("@FullName", passenger.FullName),
                    new SqlParameter("@UserName", passenger.UserName),
                    new SqlParameter("@Password", passenger.Password)
                };
                int rowsAffected = ExecuteNonQuery(query, parameters);
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Lỗi đăng ký tài khoản", ex);
            }
        }
    }
}
