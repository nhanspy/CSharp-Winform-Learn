using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for Cart
/// </summary>
public class Cart : DataTable
{
    DataColumn clMaDoUong, clTenDoUong, clDonGia, clSoLuongMua,clDelete;
    public Cart()
    {
        clMaDoUong = new DataColumn("madouong",typeof(int));
        clTenDoUong = new DataColumn("tendouong", typeof(string));
        clDonGia = new DataColumn("dongia", typeof(double));
        clSoLuongMua = new DataColumn("soluong", typeof(int));
        clDelete = new DataColumn("xoa",typeof(bool));
        Columns.AddRange(new DataColumn[] { clMaDoUong, clTenDoUong, clDonGia, clSoLuongMua,clDelete });
    }

    public void addCard(int madouong, string tendouong, double dongia)
    {
        foreach(DataRow r in Rows)
        {
            if (Convert.ToInt16(r["madouong"].ToString()) == madouong)
            {
                r["soluong"] = Convert.ToInt16(r["soluong"].ToString()) + 1;
                return;
            }
        }
        DataRow row = NewRow();
        row["madouong"] = madouong;
        row["tendouong"] = tendouong;
        row["dongia"] = dongia;
        row["soluong"] = 1;
        row["xoa"] = false;
        Rows.Add(row);
    }

    public void delCard(string madouong)
    {
        foreach(DataRow r in Rows)
        {
            if (r["madouong"].ToString().Equals(madouong))
            {
                this.Rows.Remove(r);
                return;
            }
        }
    }


}