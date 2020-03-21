using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for KetNoiDuLieu
/// </summary>
public class KetNoiDuLieu
{
    SqlConnection con;
    public KetNoiDuLieu()
    {
        con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ADMIN\source\repos\QuanLyCafe\QuanLyCafe\App_Data\dbQuanLyCafe.mdf;Integrated Security=True");
    }

    public void moKetNoi()
    {
        if (con.State == ConnectionState.Closed)
        {
            con.Open();
        }
    }

    public void dongKetNoi()
    {
        if (con.State == ConnectionState.Open)
        {
            con.Close();
        }
    }

    public DataTable getTable(string sql)
    {
        moKetNoi();
        SqlDataAdapter dpt = new SqlDataAdapter(sql, con);
        DataTable tb = new DataTable();
        dpt.Fill(tb);
        dongKetNoi();
        return tb;
    }

    public void thucThiSql(string sql)
    {
        moKetNoi();
        SqlCommand cmd = new SqlCommand(sql, con);
        cmd.ExecuteNonQuery();
        dongKetNoi();
    }

    public object getVaLues(string sql)
    {
        moKetNoi();
        object index;
        SqlCommand cmd = new SqlCommand(sql, con);
        index = cmd.ExecuteScalar();
        dongKetNoi();
        return index;
    }
}