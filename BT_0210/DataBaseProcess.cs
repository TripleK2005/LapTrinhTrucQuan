using System;
using System.Data;
using System.Data.SqlClient;

namespace BT_0210.Classes
{
    public class DataBaseProcess
    {
        private string strConnect = @"Data Source=TRIPLEK\SQLEXPRESS;
                                      Initial Catalog=BanHang;
                                      Integrated Security=True;
                                      TrustServerCertificate=True";
        private SqlConnection sqlConnect = null;

        private void OpenConnect()
        {
            if (sqlConnect == null)
                sqlConnect = new SqlConnection(strConnect);

            if (sqlConnect.State != ConnectionState.Open)
                sqlConnect.Open();
        }

        private void CloseConnect()
        {
            if (sqlConnect != null && sqlConnect.State != ConnectionState.Closed)
            {
                sqlConnect.Close();
                sqlConnect.Dispose();
                sqlConnect = null;
            }
        }

        // 📌 Dùng cho SELECT, trả về DataTable
        public DataTable ExecuteQuery(string sql, params SqlParameter[] parameters)
        {
            DataTable dt = new DataTable();
            try
            {
                OpenConnect();
                SqlCommand cmd = new SqlCommand(sql, sqlConnect);

                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            finally
            {
                CloseConnect();
            }
            return dt;
        }

        // 📌 Dùng cho INSERT, UPDATE, DELETE
        public int ExecuteNonQuery(string sql, params SqlParameter[] parameters)
        {
            int rows = 0;
            try
            {
                OpenConnect();
                SqlCommand cmd = new SqlCommand(sql, sqlConnect);

                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);

                rows = cmd.ExecuteNonQuery();
            }
            finally
            {
                CloseConnect();
            }
            return rows;
        }

        // 📌 (Optional) Trả về giá trị đơn (SELECT COUNT(*), MAX, MIN...)
        public object ExecuteScalar(string sql, params SqlParameter[] parameters)
        {
            object result = null;
            try
            {
                OpenConnect();
                SqlCommand cmd = new SqlCommand(sql, sqlConnect);

                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);

                result = cmd.ExecuteScalar();
            }
            finally
            {
                CloseConnect();
            }
            return result;
        }

        // 📌 Hàm debug xem connection string
        public string GetConnectionString()
        {
            return strConnect;
        }
    }
}
