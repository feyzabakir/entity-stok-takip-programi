<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="PersonelGuncelle.aspx.cs" Inherits="PROJE_2.Personel.PersonelGuncelle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <form runat="server" class="form-group">
          <div>
            <asp:TextBox ID="TxtID" runat="server" CssClass="form-control"  Enabled="false"></asp:TextBox> <%--Enabled değiştirlilemez--%> 
        </div>
          <br />
        <div>
            <asp:TextBox ID="TxtAdSoyad" runat="server" placeholder="Personel Adı Soyadı" CssClass="form-control"></asp:TextBox>
        </div>
          <br />
        <div>
            <asp:Button ID="Button1" runat="server" Text="Personel Güncelle" CssClass="btn btn-warning" OnClick="Button1_Click" />
        </div>
    </form>

</asp:Content>
