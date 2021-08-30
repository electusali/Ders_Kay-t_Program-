<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="OgrenciGuncellme.aspx.cs" Inherits="AdminPanel.OgrenciGuncellme" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <br />

    <form id="Form1" runat="server">


        <div class="form-group">
            <div>
                <asp:Label for="txtid " ID="Label1" Font-Bold="true" runat="server" Text="Öğrenci Adı"></asp:Label>
                <asp:TextBox ID="txtid" CssClass="form-control"  runat="server"></asp:TextBox>
            </div>
              <br />
             <div>
                <asp:Label for="txtad " ID="Label6" Font-Bold="true" runat="server" Text="Öğrenci Adı"></asp:Label>
                <asp:TextBox ID="txtad" CssClass="form-control"  runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Label for="txtSoyad " ID="Label2" Font-Bold="true" runat="server" Text="Öğrenci Soyadı"></asp:Label>
                <asp:TextBox ID="txtSoyad" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
              <br />
            <div>
                <asp:Label for="txtNumara " ID="Label3" Font-Bold="true" runat="server" Text="Öğrenci Numara"></asp:Label>
                <asp:TextBox ID="txtNumara" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
              <br />
            <div>
                <asp:Label for="txtFoto " ID="Label4" Font-Bold="true" runat="server" Text="Öğrenci Fotoraf"></asp:Label>
                <asp:TextBox ID="txtFoto" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
              <br />
            <div>
                <asp:Label for="txtSifre " ID="Label5" Font-Bold="true" runat="server" Text="Öğrenci Şifre"></asp:Label>
                <asp:TextBox ID="txtSifre" CssClass="form-control" TextMode="Password" runat="server"></asp:TextBox>
            </div>
              <br />
            
        </div>
        
        <asp:Button ID="Button1" CssClass="btn-outline-success" runat="server" Text="Kaydet"/>
        
        
    </form>

</asp:Content>
