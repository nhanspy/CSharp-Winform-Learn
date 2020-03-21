using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class ChiTiet : System.Web.UI.Page
{
    KetNoiDuLieu ketnoi;
    protected void Page_Load(object sender, EventArgs e)
    {
        string path = Server.MapPath("App_Data\\");
        ketnoi = new KetNoiDuLieu(path);
        string madouong = Request.QueryString.Get("madouong");
        string sql = "select * from douong ";
        if (madouong != null)
            sql += "where madouong = " + madouong;
        DataTable tbDoUong = ketnoi.getBang(sql);
        Repeater2.DataSource = tbDoUong;
        Repeater2.DataBind();
    }

    protected void btnThemGioHang_Click(object sender, EventArgs e)
    {
        string madouong = Request.QueryString.Get("madouong");
        Cart cart;
        if (Session["cart"] == null)
            cart = new Cart();
        else cart = (Cart)Session["cart"];
        string sql = "select * from douong ";
        if (madouong != null)
            sql += "where madouong = " + madouong;
        DataTable tbDoUong = ketnoi.getBang(sql);
        DataRow row = tbDoUong.Rows[0];
        cart.addCard(Convert.ToInt16(row[0]),row[1]+"", Convert.ToDouble(row[2]));
        Session["cart"] = cart;
        Response.Redirect("GioHang.aspx");
    }
}