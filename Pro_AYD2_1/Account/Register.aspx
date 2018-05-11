<%@ Page Title="Registrarse" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Pro_AYD2_1.Account.Register" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <h2><%: Title %>.</h2>
    <p class="text-danger">
        <asp:Literal runat="server" ID="ErrorMessage" />
    </p>

    <div class="form-horizontal">
        <h4>Crear una nueva cuenta</h4>
        <hr />
        <asp:ValidationSummary runat="server" CssClass="text-danger" />
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="nombre" CssClass="col-md-2 control-label">Nombre</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="nombre" CssClass="form-control" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="nombre"
                    CssClass="text-danger" ErrorMessage="El campo de nombre es obligatorio." />
            </div>
        </div>

       <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="apellido" CssClass="col-md-2 control-label">Apellido </asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="apellido" CssClass="form-control" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="apellido"
                    CssClass="text-danger" ErrorMessage="El campo de Apellido es obligatorio." />
            </div>
        </div>

        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="dpi" CssClass="col-md-2 control-label"> DPI </asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="dpi" CssClass="form-control" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="dpi"
                    CssClass="text-danger" ErrorMessage="El campo de dpi es obligatorio." />
            </div>
        </div>

        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="cuenta" CssClass="col-md-2 control-label">No. de Cuenta</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="cuenta" CssClass="form-control"  />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="cuenta"
                    CssClass="text-danger" ErrorMessage="El campo de No. de Cuenta es obligatorio." />
            </div>
        </div>

       <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="saldo" CssClass="col-md-2 control-label">Saldo</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="saldo" CssClass="form-control"  />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="saldo"
                    CssClass="text-danger" ErrorMessage="El campo de Saldo es obligatorio." />
            </div>
        </div>

       <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="Email" CssClass="col-md-2 control-label">Correo electrónico</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="Email" CssClass="form-control"  />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="Email"
                    CssClass="text-danger" ErrorMessage="El campo de correo electrónico es obligatorio." />
            </div>
        </div>


        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="Password" CssClass="col-md-2 control-label">Contraseña</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="Password" TextMode="Password" CssClass="form-control" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="Password"
                    CssClass="text-danger" ErrorMessage="El campo de contraseña es obligatorio." />
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="ConfirmPassword" CssClass="col-md-2 control-label">Confirmar contraseña</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="ConfirmPassword" TextMode="Password" CssClass="form-control" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="ConfirmPassword"
                    CssClass="text-danger" Display="Dynamic" ErrorMessage="El campo de confirmación de contraseña es obligatorio." />
                <asp:CompareValidator runat="server" ControlToCompare="Password" ControlToValidate="ConfirmPassword"
                    CssClass="text-danger" Display="Dynamic" ErrorMessage="La contraseña y la contraseña de confirmación no coinciden." />
                <br />
            </div>
        </div>
        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <asp:Button runat="server" OnClick="CreateUser_Click" Text="Registrarse" CssClass="btn btn-default" />
            </div>
        </div>
    </div>
</asp:Content>
