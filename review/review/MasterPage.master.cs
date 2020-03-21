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
        string path = Server.MapPath("App_Data\\");
        ketnoi = new KetNoiDuLieu(path);
        if (!IsPostBack)
        {
            string sql = "select * from danhmuc";
            DataTable tbDanhMuc = ketnoi.getBang(sql);
            this.Repeater1.DataSource = tbDanhMuc;
            this.Repeater1.DataBind();
        }
    }
}
