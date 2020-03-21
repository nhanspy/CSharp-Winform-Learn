<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ThemDoUong.aspx.cs" Inherits="ThemDoUong" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style4 {
            width: 149px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width:100%;">
        <tr>
            <td class="auto-style4">Ma do uong</td>
            <td>
                <asp:DropDownList ID="drl_MaDoUong" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">Ten do uong</td>
            <td>
                <asp:TextBox ID="txtTenDoUong" runat="server" Width="350px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">Don gia</td>
            <td>
                <asp:TextBox ID="txtDonGia" runat="server" Width="350px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">Mo ta</td>
            <td>
                <asp:TextBox ID="txtMoTa" runat="server" Width="348px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">Hinh anh</td>
            <td>
                <asp:FileUpload ID="ful_HinhAnh" runat="server" />
            </td>
        </tr>
        <tr>
            <td class="auto-style4">&nbsp;</td>
            <td>
                <asp:Button ID="btnThem" runat="server" OnClick="btnThem_Click" Text="Them" />
            </td>
        </tr>
    </table>
</asp:Content>

