<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MENU.aspx.cs" Inherits="Pro_AYD2_1.Account.MENU" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <asp:Label ID="sesion" runat="server" CssClass="col-md-2 control-label"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="noCuenta" runat="server" CssClass="col-md-2 control-label"></asp:Label>
    &nbsp;&nbsp;&nbsp;<br />
    <br />
    <br />
    <strong><span style="font-size: large">MENU - ACCIONES A TOMA<br />
    SELECCIONE LA OPCION QUE DESEE CONSULTAR</span></strong><br />
    <br />
    <br />
    <asp:Button ID="Button1" runat="server" Font-Bold="True" Font-Size="Large" Height="45px" Text="CONSULTAR SALDO" Width="386px" OnClick="Button1_Click" />
    <br />
    <br />
    <br />
    <asp:Button ID="Button2" runat="server" Font-Bold="True" Font-Size="Large" Height="53px" OnClick="Button2_Click" Text="TRANSACCION" Width="386px" />
    <br />
    <br />
    <br />
    <br />
    <br />
    <asp:Button ID="logo" runat="server" OnClick="logo_Click" Text="Logout" />
    <br />
    <br />
</asp:Content>
