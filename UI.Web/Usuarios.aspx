<%@ Page Title="Usuarios" Theme="TemaPropio" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Usuarios.aspx.cs" Inherits="UI.web.Usuarios" %>

<asp:Content ID="Content1" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
    <asp:Panel ID="gridPanel" runat ="server">
        <asp:GridView ID="gridView" runat="server" AutoGenerateColumns="False"
            SelectedRowStyle-BackColor="Black"
            SelectedRowStyle-ForeColor="White"
            DataKeyNames ="ID" OnSelectedIndexChanged="gridView_SelectedIndexChanged">
            <Columns>
                <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
                <asp:BoundField HeaderText="Apellido" DataField="Apellido" />
                <asp:BoundField HeaderText="EMail" DataField="EMail" />
                <asp:BoundField HeaderText="Usuario" DataField="NombreUsuario" />
                <asp:BoundField HeaderText="Habilitado" DataField="Habilitado" />
                <asp:CommandField ButtonType="Button" ControlStyle-CssClass="btn btn-success" SelectText="Seleccionar" ShowSelectButton="True" />
            </Columns>

        </asp:GridView>
    </asp:Panel>
    <br />
    <asp:Panel ID="gridActionsPanel" runat="server">
        <asp:LinkButton ID="editarLinkButton" runat="server" OnClick="editarLinkButton_Click">Editar</asp:LinkButton>
        <asp:LinkButton ID="eliminarLinkButton" runat="server" OnClick="eliminarLinkButton_Click">Eliminar</asp:LinkButton>
        <asp:LinkButton ID="nuevoLinkButton" runat="server" OnClick="nuevoLinkButton_Click">Nuevo</asp:LinkButton>
    </asp:Panel>
    <br />
    <asp:Panel ID="formPanel" Visible="false" CssClass="row" runat="server">
        <asp:Panel runat="server" CssClass="col">
            <asp:Label ID="nombreLabel" runat="server" Text="Nombre: " AssociatedControlID="nombreTextBox"></asp:Label>
            <asp:TextBox ID="nombreTextBox" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvNombre" runat="server" ControlToValidate="nombreTextBox" ErrorMessage="El campo no puede estar vacio" ForeColor="Red" ValidationGroup="AllValidators" Display="Dynamic"></asp:RequiredFieldValidator>
            <br />
            <asp:Label ID="apellidoLabel" runat="server" Text="Apellido: " AssociatedControlID="apellidoTextBox"></asp:Label>
            <asp:TextBox ID="apellidoTextBox" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rqvApellido" runat="server" ControlToValidate="apellidoTextBox" ErrorMessage="El campo no puede estar vacio" ForeColor="Red" ValidationGroup="AllValidators" Display="Dynamic"></asp:RequiredFieldValidator>
            <br />
            <asp:Label ID="emailLabel" runat="server" Text="EMail: " AssociatedControlID="emailTextBox"></asp:Label>
            <asp:TextBox ID="emailTextBox" runat="server"></asp:TextBox>
            <asp:RegularExpressionValidator ID="rgvMail" runat="server" ControlToValidate="emailTextBox" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" Display="Dynamic" ValidationGroup="AllValidators">El email no es valido</asp:RegularExpressionValidator>
            <asp:RequiredFieldValidator ID="rfvMail" runat="server" ControlToValidate="emailTextBox" ErrorMessage="El campo no puede estar vacio" ForeColor="Red" ValidationGroup="AllValidators" Display="Dynamic"></asp:RequiredFieldValidator>
            <br />
            <asp:Label ID="habilitadoLabel" runat="server" Text="Habilitado: " AssociatedControlID="habilitadoCheckBox"></asp:Label>
            <asp:CheckBox CssClass="auto-style1" ID="habilitadoCheckBox" runat="server"></asp:CheckBox>
            <br />           
        </asp:Panel>
        <asp:Panel runat="server" CssClass="col" >
            <asp:Label ID="nombreUsuarioLabel" runat="server" Text="Usuario: " AssociatedControlID="nombreUsuarioTextBox"></asp:Label>
            <asp:TextBox ID="nombreUsuarioTextBox" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvUsuario" runat="server" ControlToValidate="nombreUsuarioTextBox" Display="Dynamic" ErrorMessage="El campo no puede estar vacio" ForeColor="Red" ValidationGroup="AllValidators"></asp:RequiredFieldValidator>
            <br />
            <asp:Label ID="claveLabel" runat="server" Text="Clave: " AssociatedControlID="claveTextBox"></asp:Label>
            <asp:TextBox ID="claveTextBox" TextMode="Password" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvClave" runat="server" ControlToValidate="claveTextBox" Display="Dynamic" ErrorMessage="El campo no puede estar vacio" ForeColor="Red" ValidationGroup="AllValidators"></asp:RequiredFieldValidator>
            <br />
            <asp:Label ID="repetirClaveLabel" runat="server" Text="Repetir Clave: " AssociatedControlID="repetirClaveTextBox"></asp:Label>
            <asp:TextBox ID="repetirClaveTextBox" TextMode="Password" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvClave2" runat="server" ControlToValidate="repetirClaveTextBox" Display="Dynamic" ErrorMessage="El campo no puede estar vacio" ForeColor="Red" ValidationGroup="AllValidators"></asp:RequiredFieldValidator>
            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="claveTextBox" ControlToValidate="repetirClaveTextBox" ErrorMessage="Las contraseñas deben coincidir" ForeColor="Red" ValidationGroup="AllValidators"></asp:CompareValidator>
            <br />
        </asp:Panel>
    </asp:Panel>
    <br />
    <asp:Panel ID="formActionsPanel" runat="server" Visible="False">
        <asp:LinkButton ID="aceptarLinkButton" runat="server" OnClick="aceptarLinkButton_Click" ValidationGroup="AllValidators">Aceptar</asp:LinkButton>
        <asp:LinkButton ID="cancelarLinkButton" runat="server" OnClick="cancelarLinkButton_Click">Cancelar</asp:LinkButton>
    </asp:Panel>
</asp:Content>
<asp:Content ID="Content2" runat="server" contentplaceholderid="head">
    <style type="text/css">
        .auto-style1 {
            position: relative;
            display: block;
            padding-left: 1.25rem;
            left: -1px;
            top: 0px;
            width: 180px;
        }
    </style>
</asp:Content>
