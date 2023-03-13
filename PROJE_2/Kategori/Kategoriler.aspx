<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Kategoriler.aspx.cs" Inherits="PROJE_2.Kategoriler" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
      <table class="table table-bordered">
        <tr>
            <td>KATEGORİ ID</td>
            <td>KATEGORİ ADI</td>
            <td>SİL</td>
            <td>GÜNCELLE</td>
        </tr>
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
         <tr>
            <td><%# Eval("KATEGORIID") %></td>
            <td><%# Eval("KATEGORIAD") %></td>
            <td><asp:HyperLink NavigateUrl='<%# "~/Kategori/KategoriSil.aspx?KATEGORIID=" + Eval("KATEGORIID") %>' ID="HyperLink1" runat="server" CssClass="btn btn-danger">Sil</asp:HyperLink></td>
            <td><asp:HyperLink NavigateUrl='<%# "~/Kategori/KategoriGuncelle.aspx?KATEGORIID=" + Eval("KATEGORIID") %>' ID="HyperLink2" runat="server" CssClass="btn btn-success">Güncelle</asp:HyperLink></td>
        </tr>
            </ItemTemplate>
        </asp:Repeater>
    </table>
    <a href="KategoriEkle.aspx" class="btn btn-info">Yeni Kategori</a>
</asp:Content>
