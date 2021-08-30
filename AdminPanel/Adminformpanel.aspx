<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Adminformpanel.aspx.cs" Inherits="AdminPanel.Adminformpanel" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <br />

    <form id="Form1" runat="server">


        <div class="form-group">
            <div>
                <asp:Label for="txtAd " ID="Label1" Font-Bold="true" runat="server" Text="Öğrenci Adı"></asp:Label>
                <asp:TextBox ID="txtAd" CssClass="form-control"  runat="server"></asp:TextBox>
            </div>
              <br />
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
        
        <asp:Button ID="Button1" CssClass="btn-outline-success" runat="server" Text="Kaydet" OnClick="Button1_Click1" />
        
        
    </form>

</asp:Content>
