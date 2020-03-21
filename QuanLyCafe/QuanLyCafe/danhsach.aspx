<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="danhsach.aspx.cs" Inherits="danhsach" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server" >
    <asp:DataList ID="dataList" runat="server" RepeatColumns="4">
        <ItemTemplate>
            <a href ="chitiet.aspx?madouong=<%# Eval("madouong") %>">
                <img src="<%# Eval("hinhanh") %>" width="200px" height="170px" />
                <h3><%# Eval("tendouong") %></h3>
                <p><%# Eval("dongia") %></p>
            </a>
            
        </ItemTemplate>
    </asp:DataList>
</asp:Content>

