<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Personeller.aspx.cs" Inherits="PROJE_2.Personeller" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

          <table class="table table-bordered">
        <tr>
            <td>PERSONEL ID</td>
            <td> ADI SOYADI</td>
            <td>İŞLEMLER</td>
        </tr>
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
         <tr>
            <td><%# Eval("PERSONELID") %></td>
            <td><%# Eval("PERSONELADSOYAD") %></td>
            <td><asp:HyperLink NavigateUrl='<%# "PersonelSil.aspx?PERSONELID=" + Eval("PERSONELID") %>' ID="HyperLink1" runat="server" CssClass="btn btn-danger">Sil</asp:HyperLink>
            <asp:HyperLink NavigateUrl='<%# "PersonelGuncelle.aspx?PERSONELID=" + Eval("PERSONELID") %>' ID="HyperLink2" runat="server" CssClass="btn btn-success">Güncelle</asp:HyperLink></td>
        </tr>
            </ItemTemplate>
        </asp:Repeater>
    </table>
     <a href="PersonelEkle.aspx" class="btn btn-info">Yeni Personel</a>
</asp:Content>
