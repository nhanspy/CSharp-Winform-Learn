using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class DanhSach : System.Web.UI.Page
{
    KetNoiDuLieu ketnoi;
    protected void Page_Load(object sender, EventArgs e)
    {
        string path = Server.MapPath("App_Data\\");
        ketnoi = new KetNoiDuLieu(path);
        string sql = "select * from douong ";
        string condition = Request.QueryString.Get("madanhmuc");
        if (condition != null)
            sql += "where madanhmuc = " + condition;
        DataTable tbDoUong = ketnoi.getBang(sql);
        DataList1.DataSource = tbDoUong;
        DataList1.DataBind();
    }
}