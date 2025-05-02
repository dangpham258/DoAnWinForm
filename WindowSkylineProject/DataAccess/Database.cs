using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    // Exception chuyên biệt cho lỗi tại tầng Data Access
    public class DataAccessException : Exception
    {
        public DataAccessException(string message, Exception innerException)
            : base(message, innerException) { }
    }

    public class Database
    {
        protected readonly SqlConnection sqlConn;

        public Database()
        {
            string strCnn = @"Data Source=WIN;Database=Skyline;Persist Security Info=True;User ID=sa;Password=thiendang;MultipleActiveResultSets=True;";
            sqlConn = new SqlConnection(strCnn);
        }

        // Lấy dữ liệu trả về DataTable
        public DataTable ExecuteQuery(string sqlStr)
        {
            try
            {
                var dt = new DataTable();
                using (var da = new SqlDataAdapter(sqlStr, sqlConn))
                {
                    da.Fill(dt);
                }
                return dt;
            }
            catch (SqlException sqlEx)
            {
                // TODO: Ghi log lỗi tại đây
                throw new DataAccessException("Lỗi khi truy vấn dữ liệu.", sqlEx);
            }
            catch (Exception ex)
            {
                // TODO: Ghi log lỗi tại đây
                throw new DataAccessException("Lỗi không xác định khi truy vấn dữ liệu.", ex);
            }
        }

        // Thực hiện các lệnh INSERT, UPDATE, DELETE
        public int ExecuteNonQuery(string sqlStr, List<SqlParameter> parameters = null)
        {
            try
            {
                using (var cmd = new SqlCommand(sqlStr, sqlConn))
                {
                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters.ToArray());

                    sqlConn.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException sqlEx)
            {
                // TODO: Ghi log lỗi tại đây
                throw new DataAccessException("Lỗi khi thực hiện thao tác cập nhật dữ liệu.", sqlEx);
            }
            catch (Exception ex)
            {
                // TODO: Ghi log lỗi tại đây
                throw new DataAccessException("Lỗi không xác định khi thực hiện thao tác cập nhật dữ liệu.", ex);
            }
            finally
            {
                if (sqlConn.State == ConnectionState.Open)
                    sqlConn.Close();
            }
        }

        // Lấy một giá trị đơn (ví dụ: COUNT, SUM, v.v...)
        public object ExecuteScalar(string sqlStr, List<SqlParameter> parameters = null)
        {
            try
            {
                using (var cmd = new SqlCommand(sqlStr, sqlConn))
                {
                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters.ToArray());

                    sqlConn.Open();
                    return cmd.ExecuteScalar();
                }
            }
            catch (SqlException sqlEx)
            {
                // TODO: Ghi log lỗi tại đây
                throw new DataAccessException("Lỗi khi lấy giá trị đơn.", sqlEx);
            }
            catch (Exception ex)
            {
                // TODO: Ghi log lỗi tại đây
                throw new DataAccessException("Lỗi không xác định khi lấy giá trị đơn.", ex);
            }
            finally
            {
                if (sqlConn.State == ConnectionState.Open)
                    sqlConn.Close();
            }
        }

        // Hàm INSERT
        public int Insert(string tableName, Dictionary<string, object> data)
        {
            try
            {
                var columns = string.Join(", ", data.Keys);
                var paramNames = string.Join(", ", data.Keys.Select(k => "@" + k));
                string sqlStr = $"INSERT INTO {tableName} ({columns}) VALUES ({paramNames})";

                var parameters = data.Select(kvp =>
                    new SqlParameter("@" + kvp.Key, kvp.Value ?? DBNull.Value)).ToList();

                return ExecuteNonQuery(sqlStr, parameters);
            }
            catch (Exception ex)
            {
                // Nếu ExecuteNonQuery ném DataAccessException thì vào catch này
                throw;
            }
        }

        // Hàm UPDATE
        public int Update(string tableName, Dictionary<string, object> data, string whereClause, List<SqlParameter> whereParams = null)
        {
            try
            {
                var setClause = string.Join(", ", data.Keys.Select(k => $"{k} = @{k}"));
                string sqlStr = $"UPDATE {tableName} SET {setClause} WHERE {whereClause}";

                var parameters = data.Select(kvp =>
                    new SqlParameter("@" + kvp.Key, kvp.Value ?? DBNull.Value)).ToList();

                if (whereParams != null)
                    parameters.AddRange(whereParams);

                return ExecuteNonQuery(sqlStr, parameters);
            }
            catch
            {
                throw;
            }
        }

        // Hàm DELETE
        public int Delete(string tableName, string whereClause, List<SqlParameter> whereParams = null)
        {
            try
            {
                string sqlStr = $"DELETE FROM {tableName} WHERE {whereClause}";
                return ExecuteNonQuery(sqlStr, whereParams);
            }
            catch
            {
                throw;
            }
        }
    }
}
