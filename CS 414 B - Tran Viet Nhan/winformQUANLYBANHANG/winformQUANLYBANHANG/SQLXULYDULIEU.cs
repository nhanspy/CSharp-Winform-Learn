using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace winformQUANLYBANHANG
{
    class SQLXULYDULIEU
    {
        private SqlConnection con;
        public SQLXULYDULIEU()
        {
            con = new SqlConnection();
            con.ConnectionString = @"Thông tin kết nối CSDL ";
        }
        /// <summary>
        /// Phương thức mở kết nối cơ sở dữ liệu SQL Server
        /// </summary>
        public void moKetNoi()
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
        }
        /// <summary>
        /// Phương thức đóng kết nối cơ sở dữ liệu SQL Server
        /// </summary>
        public void dongKetNoi()
        {
            if (con.State == ConnectionState.Open)
                con.Close();
        }
        /// <summary>
        /// SqlDataAdapter thực thi lệnh SQL ( select * form table).
        /// Trả vể dữ liệu kiểu DataTable
        /// </summary>
        /// <param name="SQL">SQL (Select * from table)</param>
        /// <returns></returns>
        public DataTable bangDuLieu(String SQL)
        {
            DataTable tb = new DataTable();
            this.moKetNoi();
            SqlDataAdapter adp = new SqlDataAdapter(SQL, this.con);
            adp.Fill(tb);
            this.dongKetNoi();
            return tb;
        }
s
    }
}
