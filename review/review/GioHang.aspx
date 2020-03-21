<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="GioHang.aspx.cs" Inherits="GioHang" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="madouong" HeaderText="Ma do uong" />
            <asp:BoundField DataField="tendouong" HeaderText="Ten do uong" />
            <asp:BoundField DataField="dongia" HeaderText="Don gia" />
            <asp:BoundField DataField="soluong" HeaderText="So luong mua" />
            <asp:TemplateField HeaderText="Tra hang">
                <ItemTemplate>
                    <asp:CheckBox ID="ckb_Xoa" runat="server" OnCheckedChanged="ckb_Xoa_CheckedChanged" />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <asp:Button ID="btnTrahang" runat="server" OnClick="btnTrahang_Click" Text="Tra hang" />
</asp:Content>

