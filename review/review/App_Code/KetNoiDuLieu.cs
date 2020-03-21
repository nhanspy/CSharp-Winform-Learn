using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for KetNoiDuLieu
/// </summary>
public class KetNoiDuLieu
{
    SqlConnection con;
    public KetNoiDuLieu(string path)
    {
        //
        // TODO: Add constructor logic here
        //
        string strCon = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = " + path + "Database.mdf; Integrated Security = True";
        con = new SqlConnection(strCon);
    }

    public DataTable getBang(string sql)
    {
        con.Open();
        SqlDataAdapter adp = new SqlDataAdapter(sql, con);
        DataTable table = new DataTable();
        adp.Fill(table);
        con.Close();
        return table;
    }

    public void thucThiSql(string sql)
    {
        con.Open();
        SqlCommand cmd = new SqlCommand(sql, con);
        cmd.ExecuteNonQuery();
        con.Close();
    }
}