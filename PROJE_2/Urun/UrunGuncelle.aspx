<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="UrunGuncelle.aspx.cs" Inherits="PROJE_2.Urun.UrunGuncelle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

      <form runat="server" class="form-group">
        <div>
          
            <asp:TextBox ID="TxtAd" runat="server" placeholder="Ürün Adı" CssClass="form-control"></asp:TextBox>
        </div>
         <br />
         <div>
            
            <asp:TextBox ID="TxtMarka" runat="server" placeholder="Marka Adı" CssClass="form-control"></asp:TextBox>
        </div>
         <br />
         <div>
            
             <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control"></asp:DropDownList>
         </div>
         <br />
         <div>
            
            <asp:TextBox ID="TxtFiyat" runat="server" placeholder="Fiyat" CssClass="form-control"></asp:TextBox>
        </div>
         <br />
         <div>
            
            <asp:TextBox ID="TxtStok" runat="server" placeholder="Stok" CssClass="form-control"></asp:TextBox>
        </div>
         <br />
         <div>
             <asp:FileUpload ID="FileUpload1" runat="server" />
         </div>
         <br />

        <div>
            <asp:Button ID="Button1" runat="server" Text="Ürün Güncelle" CssClass="btn btn-warning" OnClick="Button1_Click"  />
        </div>
    </form>

</asp:Content>
