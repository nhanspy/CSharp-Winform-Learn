using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
public partial class danhsach : System.Web.UI.Page
{
    KetNoiDuLieu ketnoi;
    protected void Page_Load(object sender, EventArgs e)
    {
        ketnoi = new KetNoiDuLieu();
        string sql = "select top(10) * from douong ";
        string madanhmuc = Request.QueryString.Get("madanhmuc");
        if (madanhmuc != null)
        {
            sql += " where madanhmuc = " + madanhmuc;
        }
        DataTable tb = ketnoi.getTable(sql);
        dataList.DataSource = tb;
        dataList.DataBind();
    }
}