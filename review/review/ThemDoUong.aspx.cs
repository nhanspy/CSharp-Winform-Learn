using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
public partial class ThemDoUong : System.Web.UI.Page
{
    KetNoiDuLieu ketnoi;
    int madanhmuc;
    float dongia;
    string tendouong,mota,hinhanh;
    protected void Page_Load(object sender, EventArgs e)
    {
        ketnoi = new KetNoiDuLieu(Server.MapPath("App_Data\\"));
        if (!IsPostBack) loadDrlMaDoUong();
    }

    private void loadDrlMaDoUong()
    {
        string sql = "select * from danhmuc";
        DataTable tbDanhMuc = ketnoi.getBang(sql);
        drl_MaDoUong.DataSource = tbDanhMuc;
        drl_MaDoUong.DataValueField = "madanhmuc";
        drl_MaDoUong.DataTextField = "tendanhmuc";
        drl_MaDoUong.DataBind();
    }

    protected void btnThem_Click(object sender, EventArgs e)
    {
        try
        {
            madanhmuc = Convert.ToInt16(drl_MaDoUong.SelectedValue.ToString());
            dongia = float.Parse(txtDonGia.Text);
            tendouong = txtTenDoUong.Text;
            mota = txtMoTa.Text;
            hinhanh = @"/images/" + ful_HinhAnh.FileName;
            string sql = "insert into douong(tendouong,dongia,mota,hinhanh,madanhmuc) values('" + tendouong + "'," + dongia + ",'" + mota + "','" + hinhanh + "'," + madanhmuc + ")";
            ketnoi.thucThiSql(sql);
        } catch (Exception) {
            Response.Write("<script>alert('Vui long nhap lai')</script>");
        }
        clear();
    }

    private void clear()
    {
        drl_MaDoUong.SelectedIndex = 0;
        txtDonGia.Text = "";
        txtMoTa.Text = "";
        txtTenDoUong.Text = "";
    }
}