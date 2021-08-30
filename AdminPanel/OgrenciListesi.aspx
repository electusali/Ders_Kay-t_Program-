<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="OgrenciListesi.aspx.cs" Inherits="AdminPanel.OgrenciListesi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <table class="table table-bordered table-hover">
        <tr>
            <th>Öğrenci Id</th>
            <th>Öğrenci Ad</th>
            <th>Öğrenci Soyad</th>
            <th>Öğrenci Numara</th>
            <th>Öğrenci Şifre</th>
            <th>Öğrenci Fotoraf</th>
            <th>Bakiye</th>
            <th>İşlemler</th>
        </tr>
        <tbody>

            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>

                        <td><%# Eval("ID") %> </td>
                        <td><%# Eval("AD") %>  </td>
                        <td><%# Eval("SOYAD") %>  </td>
                        <td><%# Eval("NUMARA") %>  </td>
                        <td><%# Eval("FOTORAF") %>  </td>
                        <td><%# Eval("SİFRE") %> </td>
                        <td><%# Eval("BAKİYE") %> </td>
                        <td>
                            <asp:HyperLink ID="HyperLink1" NavigateUrl='<%# "~/OgrenciSil.aspx?Ogrid="+ Eval("ID") %>'   CssClass="btn btn-danger" runat="server">Sil</asp:HyperLink>
                            <asp:HyperLink ID="HyperLink2" NavigateUrl='<%# "~/OgrenciSil.aspx?Ogrid="+ Eval("ID") %>' CssClass="btn btn-success" runat="server">Güncelle</asp:HyperLink>
                        </td>
                    </tr>
                </ItemTemplate>

            </asp:Repeater>


        </tbody>


    </table>
    <br />
</asp:Content>
