using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class GioHang : System.Web.UI.Page
{
    Cart cart;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack && Session["cart"] != null)
        {
            cart = (Cart)Session["cart"];
            Load();
        }
    }

    private void Load()
    {
        GridView1.DataSource = cart;
        GridView1.DataBind();
    }

    protected void btnTrahang_Click(object sender, EventArgs e)
    {
        cart = (Cart)Session["cart"];
        foreach (GridViewRow row in GridView1.Rows)
        {
            CheckBox ckb = (CheckBox)row.FindControl("ckb_Xoa");
            if (ckb.Checked == true)
            {
                cart.delCard(row.Cells[0].Text);
                Session["cart"] = cart;
            }
        }
        Load();
    }

    protected void ckb_Xoa_CheckedChanged(object sender, EventArgs e)
    {
        
    }
}