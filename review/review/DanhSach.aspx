<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="DanhSach.aspx.cs" Inherits="DanhSach" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:DataList ID="DataList1" runat="server" CellSpacing="50" RepeatColumns="4">
        <ItemTemplate>
            <a href ="ChiTiet.aspx?madouong=<%# Eval("madouong") %>">
                <img src ="<%# Eval("hinhanh") %>" />
             </a>
            <br>
            Ten: <%# Eval("tendouong") %>
            <br>
            
        </ItemTemplate>
    </asp:DataList>
</asp:Content>

