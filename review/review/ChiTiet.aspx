<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ChiTiet.aspx.cs" Inherits="ChiTiet" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Repeater ID="Repeater2" runat="server">
        <ItemTemplate>
            <table style="width:100%;">
                <tr>
                    <td><img src="<%# Eval("hinhanh") %>"/></td>
                    <td>
                        Ten: <%# Eval("tendouong") %>
                        <br>
                        Don gia: Ten: <%# Eval("dongia") %>
                        <br>
                        Mo ta: Ten: <%# Eval("mota") %>
                    </td>
                </tr>
            </table>
            
            
        </ItemTemplate>
    </asp:Repeater>
    
    <asp:Button ID="btnThemGioHang" runat="server" OnClick="btnThemGioHang_Click" Text="Them Gio Hang" />
    
</asp:Content>

