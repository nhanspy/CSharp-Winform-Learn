using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class MasterPage : System.Web.UI.MasterPage
{
    KetNoiDuLieu ketnoi;
    protected void Page_Load(object sender, EventArgs e)
    {
        ketnoi = new KetNoiDuLieu();
        DataTable tb = new DataTable();
        string sql = "select * from danhmuc";
        tb = ketnoi.getTable(sql);
        rpt_DanhMuc.DataSource = tb;
        rpt_DanhMuc.DataBind();
    }

    protected void rpt_DanhMuc_ItemCommand(object source, RepeaterCommandEventArgs e)
    {

    }
}
