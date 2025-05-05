using DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataAccess
{
    public class FeedbackAccess
    {
        readonly Database db = new Database();
        public bool InsertFeedback(Feedback fb)
        {
            try
            {
                string sqlStr = "INSERT INTO Table_FeedbackDatabase (FullName, PhoneNumber, Type, Detail, Status) " +
                    "VALUES (@FullName, @PhoneNumber, @Type, @Detail, @Status)";

                List<SqlParameter> parameters = new List<SqlParameter>
                {
                    new SqlParameter("@FullName", fb.FullName),
                    new SqlParameter("@PhoneNumber", fb.PhoneNumber),
                    new SqlParameter("@Type", fb.Type),
                    new SqlParameter("@Detail", fb.Detail),
                    new SqlParameter("@Status", fb.Status)
                };
                return db.ExecuteNonQuery(sqlStr, parameters) > 0;
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Lỗi khi thêm phản hồi", ex);
            }
        }

        public bool SetStatusFeedback(Feedback fb)
        {
            try
            {
                string sqlStr = "UPDATE Table_FeedbackDatabase SET Status = @Status WHERE FeedbackID = @ID";
                List<SqlParameter> parameters = new List<SqlParameter>
                {
                    new SqlParameter("@Status", fb.Status),
                    new SqlParameter("@ID", fb.FeedbackId)
                };
                return db.ExecuteNonQuery(sqlStr, parameters) > 0;
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Lỗi khi chuyển đổi trạng thái phản hồi", ex);
            }
        }
    }
}
