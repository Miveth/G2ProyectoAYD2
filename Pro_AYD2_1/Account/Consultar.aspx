<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Consultar.aspx.cs" Inherits="Pro_AYD2_1.Account.Consultar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <strong><span style="font-size: small">
    <br />
    <asp:Label ID="sesion" runat="server" CssClass="col-md-2 control-label"></asp:Label>
    &nbsp;&nbsp;&nbsp;
    <asp:Label ID="noCuenta" runat="server" CssClass="col-md-2 control-label"></asp:Label>
    &nbsp;&nbsp;</span><span style="font-size: large">&nbsp;<br />
    <br />
    USUARIO:</span></strong>
    <asp:Label ID="nombre" runat="server" Font-Bold="True" Font-Size="Large"></asp:Label>
&nbsp;
    <asp:Label ID="apellido" runat="server" Font-Bold="True" Font-Size="Medium"></asp:Label>
    <br />
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
    <strong><span style="font-size: large">CUENTA: </span></strong>
    <asp:Label ID="cuenta" runat="server" Font-Bold="True" Font-Size="Large"></asp:Label>
    <br />
    <br />
    <strong><em><span style="font-size: x-large">ESTADO DE CUENTA:</span></em></strong>&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="monto" runat="server" Font-Bold="True" Font-Size="XX-Large" ForeColor="#0033CC"></asp:Label>
&nbsp;<br />
    <br />
    <br />
    &nbsp;<asp:Button ID="consulta" runat="server" Font-Bold="True" Font-Size="Large" OnClick="Button1_Click" Text="Consultar Ahora" />
    <br />
    <br />
    <asp:Label ID="mensaje" runat="server" Font-Italic="True" ForeColor="#00CC00" style="font-weight: 700"></asp:Label>
    <br />
    <br />
    <br />
    <br />
    <asp:Button ID="Button1" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="Small" OnClick="Button1_Click1" Text="VOLVER A MENU PRINCIPAL" />
    <br />
    <br />
    <br />
    <br />
    <asp:Button ID="logo" runat="server" OnClick="logo_Click" Text="Logout" />
    </asp:Content>
